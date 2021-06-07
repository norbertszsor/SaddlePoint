using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Msagl.GraphViewerGdi;
using Microsoft.Msagl.Drawing;
using Newtonsoft.Json;
using System.Windows.Forms;


namespace MiWpro4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.gViewerOne.Visible = false;
            this.buttonGraphShow.Enabled = false;
            this.textBoxSwtichChar.Text = "Protagonist";
        }

    

        private void buttonGraphGenerate_Click(object sender, EventArgs e)
        {
            bool state = textBoxSwtichChar.Text == "Protagonist" ? true : false;
            List<int> tmpStructure = this.textBoxStructure.Text.Split(' ').ToList().Select(int.Parse).ToList();
            tmpStructure.Add(int.Parse(this.textBoxCondition.Text));
            App.coreGraph = new Tree.Graph(tmpStructure, state);
            

            DialogResult dialogResult = MessageBox.Show("Graph has been created, should program view a structrue for inspection?", 
                "Graph Info",MessageBoxButtons.YesNo);

            this.richTextBoxGraphView.Text = dialogResult == DialogResult.Yes ? 
                JsonConvert.SerializeObject(App.coreGraph, Formatting.Indented) : "";

            this.buttonGraphShow.Enabled = true;
        }

        private void textBoxCondition_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonGraphShow_Click(object sender, EventArgs e)
        {
            
            GViewer viewer = new GViewer();
            Graph graph = new Graph("graph");

            foreach(var edge in App.coreGraph.graphEdges)
            {
                graph.AddEdge(edge.masterNode.nodeId, edge.slaveNode.nodeId).LabelText = edge.value.ToString();

                graph.FindNode(edge.masterNode.nodeId).LabelText = edge.masterNode.checkActiveStatus() != true ?
                    "  Value: " + edge.masterNode.nodeValue.ToString() +
                    "\n Score: " + edge.masterNode.nodeScore.ToString() +                 
                    "\n     End" :
                    edge.masterNode.nodeType + 
                    "\n  Value: " + edge.masterNode.nodeValue.ToString();

                graph.FindNode(edge.slaveNode.nodeId).LabelText = edge.slaveNode.checkActiveStatus() != true ?
                    "  Value: " + edge.slaveNode.nodeValue.ToString() +
                    "\n Score: " + edge.slaveNode.nodeScore.ToString() +                
                    "\n     End" :
                    edge.slaveNode.nodeType + 
                    "\n  Value: " + edge.slaveNode.nodeValue.ToString();

                      

            }

            viewer.Graph = graph;
            viewer.Dock = DockStyle.Fill;
            if (App.coreGraph.graphEdges.Count >= 20)
            {
                MessageBox.Show("The graph is too large, the program will display it in a new window", "GraphViewer", MessageBoxButtons.OK);
                Form graphForm = new Form();
                graphForm.SuspendLayout();
                graphForm.Controls.Add(viewer);
                graphForm.ResumeLayout();
                graphForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("The graph seems to be small one, the program will display it in a current window", "GraphViewer", MessageBoxButtons.OK);
                this.gViewerOne.Visible = true;
                this.gViewerOne.SuspendLayout();
                this.gViewerOne.Controls.Add(viewer);
                this.gViewerOne.ResumeLayout();
                this.gViewerOne.Graph = graph;
            }

            
        }

        private void buttonSwtichChar_Click(object sender, EventArgs e)
        {
            this.textBoxSwtichChar.Text = textBoxSwtichChar.Text == "Antagonist" ? "Protagonist" : "Antagonist";
        }

        private void buttonSaddlePoint_Click(object sender, EventArgs e)
        {
            App.coreGraph = Tree.SaddlePoint.saddleFull(App.coreGraph);


            GViewer viewer = new GViewer();
            Graph graph = new Graph("graph");

            foreach (var edge in App.coreGraph.graphEdges)
            {
                if(edge.isColor== true)
                {
                    graph.AddEdge(edge.masterNode.nodeId, edge.slaveNode.nodeId).LabelText = edge.value.ToString();
                    graph.AddEdge(edge.masterNode.nodeId, edge.slaveNode.nodeId).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    graph.FindNode(edge.masterNode.nodeId).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    graph.FindNode(edge.slaveNode.nodeId).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                }
                else
                {
                    graph.AddEdge(edge.masterNode.nodeId, edge.slaveNode.nodeId).LabelText = edge.value.ToString();
                }
               

                graph.FindNode(edge.masterNode.nodeId).LabelText = edge.masterNode.checkActiveStatus() != true ?
                    "  Score: " + edge.masterNode.nodeScore.ToString() +
                    "\n  Value: " + edge.masterNode.nodeValue.ToString() +                   
                    "\n     End" :
                    edge.masterNode.nodeType +
                    "\n Score: " + edge.masterNode.nodeScore.ToString() +
                    "\n  Value: " + edge.masterNode.nodeValue.ToString();

                graph.FindNode(edge.slaveNode.nodeId).LabelText = edge.slaveNode.checkActiveStatus() != true ?
                    "  Score: " + edge.slaveNode.nodeScore.ToString() +
                    "\n  Value: " + edge.slaveNode.nodeValue.ToString() +                 
                    "\n     End" :
                    edge.slaveNode.nodeType +
                    "\n Score: " + edge.slaveNode.nodeScore.ToString() +
                    "\n  Value: " + edge.slaveNode.nodeValue.ToString();



            }



            viewer.Graph = graph;
            viewer.Dock = DockStyle.Fill;
            if (App.coreGraph.graphEdges.Count >= 20)
            {
                Form graphForm = new Form();
                graphForm.SuspendLayout();
                graphForm.Controls.Add(viewer);
                graphForm.ResumeLayout();
                graphForm.ShowDialog();
            }
            else
            {
                this.gViewerOne.Visible = true;
                this.gViewerOne.SuspendLayout();
                this.gViewerOne.Controls.Add(viewer);
                this.gViewerOne.ResumeLayout();
                this.gViewerOne.Graph = graph;
            }
            this.richTextBoxGraphView.Text = JsonConvert.SerializeObject(App.coreGraph, Formatting.Indented);
        }

    }
}
