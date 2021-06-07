
namespace MiWpro4
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxStructure = new System.Windows.Forms.TextBox();
            this.buttonGraphGenerate = new System.Windows.Forms.Button();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.labelStructure = new System.Windows.Forms.Label();
            this.labelFinalCondtition = new System.Windows.Forms.Label();
            this.richTextBoxGraphView = new System.Windows.Forms.RichTextBox();
            this.labelViewStructure = new System.Windows.Forms.Label();
            this.buttonGraphShow = new System.Windows.Forms.Button();
            this.gViewerOne = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.buttonSwtichChar = new System.Windows.Forms.Button();
            this.textBoxSwtichChar = new System.Windows.Forms.TextBox();
            this.labelSwtichCharacter = new System.Windows.Forms.Label();
            this.buttonSaddlePoint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxStructure
            // 
            this.textBoxStructure.Location = new System.Drawing.Point(12, 24);
            this.textBoxStructure.Name = "textBoxStructure";
            this.textBoxStructure.Size = new System.Drawing.Size(114, 20);
            this.textBoxStructure.TabIndex = 0;
            this.textBoxStructure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonGraphGenerate
            // 
            this.buttonGraphGenerate.Location = new System.Drawing.Point(189, 53);
            this.buttonGraphGenerate.Name = "buttonGraphGenerate";
            this.buttonGraphGenerate.Size = new System.Drawing.Size(82, 23);
            this.buttonGraphGenerate.TabIndex = 1;
            this.buttonGraphGenerate.Text = "Generate";
            this.buttonGraphGenerate.UseVisualStyleBackColor = true;
            this.buttonGraphGenerate.Click += new System.EventHandler(this.buttonGraphGenerate_Click);
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.Location = new System.Drawing.Point(132, 24);
            this.textBoxCondition.MaxLength = 2;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.Size = new System.Drawing.Size(51, 20);
            this.textBoxCondition.TabIndex = 2;
            this.textBoxCondition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCondition.TextChanged += new System.EventHandler(this.textBoxCondition_TextChanged);
            // 
            // labelStructure
            // 
            this.labelStructure.AutoSize = true;
            this.labelStructure.Location = new System.Drawing.Point(12, 8);
            this.labelStructure.Name = "labelStructure";
            this.labelStructure.Size = new System.Drawing.Size(80, 13);
            this.labelStructure.TabIndex = 3;
            this.labelStructure.Text = "Type Structure ";
            // 
            // labelFinalCondtition
            // 
            this.labelFinalCondtition.AutoSize = true;
            this.labelFinalCondtition.Location = new System.Drawing.Point(132, 8);
            this.labelFinalCondtition.Name = "labelFinalCondtition";
            this.labelFinalCondtition.Size = new System.Drawing.Size(51, 13);
            this.labelFinalCondtition.TabIndex = 4;
            this.labelFinalCondtition.Text = "Condition";
            // 
            // richTextBoxGraphView
            // 
            this.richTextBoxGraphView.Location = new System.Drawing.Point(12, 128);
            this.richTextBoxGraphView.Name = "richTextBoxGraphView";
            this.richTextBoxGraphView.ReadOnly = true;
            this.richTextBoxGraphView.Size = new System.Drawing.Size(216, 310);
            this.richTextBoxGraphView.TabIndex = 5;
            this.richTextBoxGraphView.Text = "";
            // 
            // labelViewStructure
            // 
            this.labelViewStructure.AutoSize = true;
            this.labelViewStructure.Location = new System.Drawing.Point(12, 112);
            this.labelViewStructure.Name = "labelViewStructure";
            this.labelViewStructure.Size = new System.Drawing.Size(102, 13);
            this.labelViewStructure.TabIndex = 6;
            this.labelViewStructure.Text = "Object View(Debug)";
            // 
            // buttonGraphShow
            // 
            this.buttonGraphShow.Location = new System.Drawing.Point(189, 82);
            this.buttonGraphShow.Name = "buttonGraphShow";
            this.buttonGraphShow.Size = new System.Drawing.Size(82, 23);
            this.buttonGraphShow.TabIndex = 7;
            this.buttonGraphShow.Text = "Show Graph";
            this.buttonGraphShow.UseVisualStyleBackColor = true;
            this.buttonGraphShow.Click += new System.EventHandler(this.buttonGraphShow_Click);
            // 
            // gViewerOne
            // 
            this.gViewerOne.ArrowheadLength = 10D;
            this.gViewerOne.AsyncLayout = false;
            this.gViewerOne.AutoScroll = true;
            this.gViewerOne.BackwardEnabled = false;
            this.gViewerOne.BuildHitTree = true;
            this.gViewerOne.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewerOne.EdgeInsertButtonVisible = true;
            this.gViewerOne.FileName = "";
            this.gViewerOne.ForwardEnabled = false;
            this.gViewerOne.Graph = null;
            this.gViewerOne.InsertingEdge = false;
            this.gViewerOne.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewerOne.LayoutEditingEnabled = true;
            this.gViewerOne.Location = new System.Drawing.Point(250, 128);
            this.gViewerOne.LooseOffsetForRouting = 0.25D;
            this.gViewerOne.MouseHitDistance = 0.05D;
            this.gViewerOne.Name = "gViewerOne";
            this.gViewerOne.NavigationVisible = true;
            this.gViewerOne.NeedToCalculateLayout = true;
            this.gViewerOne.OffsetForRelaxingInRouting = 0.6D;
            this.gViewerOne.PaddingForEdgeRouting = 8D;
            this.gViewerOne.PanButtonPressed = false;
            this.gViewerOne.SaveAsImageEnabled = true;
            this.gViewerOne.SaveAsMsaglEnabled = true;
            this.gViewerOne.SaveButtonVisible = true;
            this.gViewerOne.SaveGraphButtonVisible = true;
            this.gViewerOne.SaveInVectorFormatEnabled = true;
            this.gViewerOne.Size = new System.Drawing.Size(538, 310);
            this.gViewerOne.TabIndex = 8;
            this.gViewerOne.TightOffsetForRouting = 0.125D;
            this.gViewerOne.ToolBarIsVisible = true;
            this.gViewerOne.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("gViewerOne.Transform")));
            this.gViewerOne.UndoRedoButtonsVisible = true;
            this.gViewerOne.WindowZoomButtonPressed = false;
            this.gViewerOne.ZoomF = 1D;
            this.gViewerOne.ZoomWindowThreshold = 0.05D;
            // 
            // buttonSwtichChar
            // 
            this.buttonSwtichChar.Location = new System.Drawing.Point(189, 24);
            this.buttonSwtichChar.Name = "buttonSwtichChar";
            this.buttonSwtichChar.Size = new System.Drawing.Size(82, 23);
            this.buttonSwtichChar.TabIndex = 9;
            this.buttonSwtichChar.Text = "Swtich";
            this.buttonSwtichChar.UseVisualStyleBackColor = true;
            this.buttonSwtichChar.Click += new System.EventHandler(this.buttonSwtichChar_Click);
            // 
            // textBoxSwtichChar
            // 
            this.textBoxSwtichChar.Location = new System.Drawing.Point(277, 24);
            this.textBoxSwtichChar.Name = "textBoxSwtichChar";
            this.textBoxSwtichChar.ReadOnly = true;
            this.textBoxSwtichChar.Size = new System.Drawing.Size(100, 20);
            this.textBoxSwtichChar.TabIndex = 10;
            this.textBoxSwtichChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSwtichCharacter
            // 
            this.labelSwtichCharacter.AutoSize = true;
            this.labelSwtichCharacter.Location = new System.Drawing.Point(274, 9);
            this.labelSwtichCharacter.Name = "labelSwtichCharacter";
            this.labelSwtichCharacter.Size = new System.Drawing.Size(36, 13);
            this.labelSwtichCharacter.TabIndex = 11;
            this.labelSwtichCharacter.Text = "Player";
            // 
            // buttonSaddlePoint
            // 
            this.buttonSaddlePoint.Location = new System.Drawing.Point(383, 22);
            this.buttonSaddlePoint.Name = "buttonSaddlePoint";
            this.buttonSaddlePoint.Size = new System.Drawing.Size(82, 23);
            this.buttonSaddlePoint.TabIndex = 12;
            this.buttonSaddlePoint.Text = "Find Score";
            this.buttonSaddlePoint.UseVisualStyleBackColor = true;
            this.buttonSaddlePoint.Click += new System.EventHandler(this.buttonSaddlePoint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaddlePoint);
            this.Controls.Add(this.labelSwtichCharacter);
            this.Controls.Add(this.textBoxSwtichChar);
            this.Controls.Add(this.buttonSwtichChar);
            this.Controls.Add(this.gViewerOne);
            this.Controls.Add(this.buttonGraphShow);
            this.Controls.Add(this.labelViewStructure);
            this.Controls.Add(this.richTextBoxGraphView);
            this.Controls.Add(this.labelFinalCondtition);
            this.Controls.Add(this.labelStructure);
            this.Controls.Add(this.textBoxCondition);
            this.Controls.Add(this.buttonGraphGenerate);
            this.Controls.Add(this.textBoxStructure);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStructure;
        private System.Windows.Forms.Button buttonGraphGenerate;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.Label labelStructure;
        private System.Windows.Forms.Label labelFinalCondtition;
        private System.Windows.Forms.RichTextBox richTextBoxGraphView;
        private System.Windows.Forms.Label labelViewStructure;
        private System.Windows.Forms.Button buttonGraphShow;
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewerOne;
        private System.Windows.Forms.Button buttonSwtichChar;
        private System.Windows.Forms.TextBox textBoxSwtichChar;
        private System.Windows.Forms.Label labelSwtichCharacter;
        private System.Windows.Forms.Button buttonSaddlePoint;
    }
}

