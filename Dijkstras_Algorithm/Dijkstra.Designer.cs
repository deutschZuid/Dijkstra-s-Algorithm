namespace Dijkstras_Algorithm
{
    partial class Dijkstra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dijkstra));
            this.gbVertex = new System.Windows.Forms.GroupBox();
            this.btnAddvertex = new System.Windows.Forms.Button();
            this.gbEdge = new System.Windows.Forms.GroupBox();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSecondNodeID = new System.Windows.Forms.TextBox();
            this.txtFirstNodeID = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbSelections = new System.Windows.Forms.GroupBox();
            this.btnSetSource = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lboEdges = new System.Windows.Forms.ListBox();
            this.lboVertexes = new System.Windows.Forms.ListBox();
            this.lblVertices = new System.Windows.Forms.Label();
            this.gpResults = new System.Windows.Forms.GroupBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteVertex = new System.Windows.Forms.Button();
            this.btnDeleteEdge = new System.Windows.Forms.Button();
            this.lboLowestCostPath = new System.Windows.Forms.ListBox();
            this.gbVertex.SuspendLayout();
            this.gbEdge.SuspendLayout();
            this.gbSelections.SuspendLayout();
            this.gpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVertex
            // 
            this.gbVertex.Controls.Add(this.btnAddvertex);
            this.gbVertex.Location = new System.Drawing.Point(12, 12);
            this.gbVertex.Name = "gbVertex";
            this.gbVertex.Size = new System.Drawing.Size(142, 133);
            this.gbVertex.TabIndex = 6;
            this.gbVertex.TabStop = false;
            this.gbVertex.Text = "Add a new vertex";
            // 
            // btnAddvertex
            // 
            this.btnAddvertex.Location = new System.Drawing.Point(21, 19);
            this.btnAddvertex.Name = "btnAddvertex";
            this.btnAddvertex.Size = new System.Drawing.Size(104, 104);
            this.btnAddvertex.TabIndex = 1;
            this.btnAddvertex.Text = "Add a new vertex";
            this.btnAddvertex.UseVisualStyleBackColor = true;
            this.btnAddvertex.Click += new System.EventHandler(this.btnAddvertex_Click);
            // 
            // gbEdge
            // 
            this.gbEdge.Controls.Add(this.btnAddEdge);
            this.gbEdge.Controls.Add(this.label6);
            this.gbEdge.Controls.Add(this.label5);
            this.gbEdge.Controls.Add(this.txtSecondNodeID);
            this.gbEdge.Controls.Add(this.txtFirstNodeID);
            this.gbEdge.Controls.Add(this.txtLength);
            this.gbEdge.Controls.Add(this.label4);
            this.gbEdge.Location = new System.Drawing.Point(170, 12);
            this.gbEdge.Name = "gbEdge";
            this.gbEdge.Size = new System.Drawing.Size(163, 133);
            this.gbEdge.TabIndex = 7;
            this.gbEdge.TabStop = false;
            this.gbEdge.Text = "Add a new edge";
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.Location = new System.Drawing.Point(41, 100);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(75, 23);
            this.btnAddEdge.TabIndex = 5;
            this.btnAddEdge.Text = "Add edge";
            this.btnAddEdge.UseVisualStyleBackColor = true;
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Second Vertex ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Vertex ID";
            // 
            // txtSecondNodeID
            // 
            this.txtSecondNodeID.Location = new System.Drawing.Point(109, 45);
            this.txtSecondNodeID.Name = "txtSecondNodeID";
            this.txtSecondNodeID.Size = new System.Drawing.Size(46, 20);
            this.txtSecondNodeID.TabIndex = 3;
            // 
            // txtFirstNodeID
            // 
            this.txtFirstNodeID.Location = new System.Drawing.Point(109, 19);
            this.txtFirstNodeID.Name = "txtFirstNodeID";
            this.txtFirstNodeID.Size = new System.Drawing.Size(46, 20);
            this.txtFirstNodeID.TabIndex = 2;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(109, 71);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(46, 20);
            this.txtLength.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cost";
            // 
            // gbSelections
            // 
            this.gbSelections.Controls.Add(this.btnDeleteEdge);
            this.gbSelections.Controls.Add(this.btnDeleteVertex);
            this.gbSelections.Controls.Add(this.btnSetSource);
            this.gbSelections.Controls.Add(this.lblSource);
            this.gbSelections.Controls.Add(this.btnCalculate);
            this.gbSelections.Controls.Add(this.label8);
            this.gbSelections.Controls.Add(this.label7);
            this.gbSelections.Controls.Add(this.lboEdges);
            this.gbSelections.Controls.Add(this.lboVertexes);
            this.gbSelections.Location = new System.Drawing.Point(363, 12);
            this.gbSelections.Name = "gbSelections";
            this.gbSelections.Size = new System.Drawing.Size(321, 376);
            this.gbSelections.TabIndex = 8;
            this.gbSelections.TabStop = false;
            // 
            // btnSetSource
            // 
            this.btnSetSource.Location = new System.Drawing.Point(62, 252);
            this.btnSetSource.Name = "btnSetSource";
            this.btnSetSource.Size = new System.Drawing.Size(118, 40);
            this.btnSetSource.TabIndex = 8;
            this.btnSetSource.Text = "Set as Source";
            this.btnSetSource.UseVisualStyleBackColor = true;
            this.btnSetSource.Click += new System.EventHandler(this.btnSetSource_Click);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(204, 261);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(51, 20);
            this.lblSource.TabIndex = 5;
            this.lblSource.Text = "None";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(23, 319);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(263, 42);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate shortest path between Source and Target";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Edges";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Vertices";
            // 
            // lboEdges
            // 
            this.lboEdges.FormattingEnabled = true;
            this.lboEdges.Location = new System.Drawing.Point(8, 134);
            this.lboEdges.Name = "lboEdges";
            this.lboEdges.Size = new System.Drawing.Size(305, 108);
            this.lboEdges.TabIndex = 7;
            // 
            // lboVertexes
            // 
            this.lboVertexes.FormattingEnabled = true;
            this.lboVertexes.Location = new System.Drawing.Point(8, 32);
            this.lboVertexes.Name = "lboVertexes";
            this.lboVertexes.Size = new System.Drawing.Size(305, 69);
            this.lboVertexes.TabIndex = 6;
            // 
            // lblVertices
            // 
            this.lblVertices.AutoSize = true;
            this.lblVertices.Location = new System.Drawing.Point(3, 16);
            this.lblVertices.Name = "lblVertices";
            this.lblVertices.Size = new System.Drawing.Size(300, 13);
            this.lblVertices.TabIndex = 9;
            this.lblVertices.Text = "Paths with lowest cost between source and every other vertex\r\n";
            // 
            // gpResults
            // 
            this.gpResults.Controls.Add(this.lboLowestCostPath);
            this.gpResults.Controls.Add(this.btnHelp);
            this.gpResults.Controls.Add(this.txtTotalCost);
            this.gpResults.Controls.Add(this.label9);
            this.gpResults.Controls.Add(this.lblVertices);
            this.gpResults.Location = new System.Drawing.Point(12, 172);
            this.gpResults.Name = "gpResults";
            this.gpResults.Size = new System.Drawing.Size(321, 216);
            this.gpResults.TabIndex = 11;
            this.gpResults.TabStop = false;
            this.gpResults.Text = "Results";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(6, 190);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCost.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total Cost:";
            // 
            // btnHelp
            // 
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.Location = new System.Drawing.Point(287, 187);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 23);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(340, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "    ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(339, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "    ";
            // 
            // btnDeleteVertex
            // 
            this.btnDeleteVertex.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteVertex.Image")));
            this.btnDeleteVertex.Location = new System.Drawing.Point(290, 9);
            this.btnDeleteVertex.Name = "btnDeleteVertex";
            this.btnDeleteVertex.Size = new System.Drawing.Size(23, 23);
            this.btnDeleteVertex.TabIndex = 11;
            this.btnDeleteVertex.TabStop = false;
            this.btnDeleteVertex.UseVisualStyleBackColor = true;
            this.btnDeleteVertex.Click += new System.EventHandler(this.btnDeleteVertex_Click);
            // 
            // btnDeleteEdge
            // 
            this.btnDeleteEdge.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteEdge.Image")));
            this.btnDeleteEdge.Location = new System.Drawing.Point(290, 111);
            this.btnDeleteEdge.Name = "btnDeleteEdge";
            this.btnDeleteEdge.Size = new System.Drawing.Size(23, 23);
            this.btnDeleteEdge.TabIndex = 12;
            this.btnDeleteEdge.TabStop = false;
            this.btnDeleteEdge.UseVisualStyleBackColor = true;
            this.btnDeleteEdge.Click += new System.EventHandler(this.btnDeleteEdge_Click);
            // 
            // lboLowestCostPath
            // 
            this.lboLowestCostPath.FormattingEnabled = true;
            this.lboLowestCostPath.Location = new System.Drawing.Point(6, 41);
            this.lboLowestCostPath.Name = "lboLowestCostPath";
            this.lboLowestCostPath.Size = new System.Drawing.Size(299, 121);
            this.lboLowestCostPath.TabIndex = 14;
            this.lboLowestCostPath.SelectedIndexChanged += new System.EventHandler(this.lboLowestCostPath_SelectedIndexChanged);
            // 
            // Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpResults);
            this.Controls.Add(this.gbSelections);
            this.Controls.Add(this.gbEdge);
            this.Controls.Add(this.gbVertex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dijkstra";
            this.Text = "Dijkstra\'s Algorithm";
            this.gbVertex.ResumeLayout(false);
            this.gbEdge.ResumeLayout(false);
            this.gbEdge.PerformLayout();
            this.gbSelections.ResumeLayout(false);
            this.gbSelections.PerformLayout();
            this.gpResults.ResumeLayout(false);
            this.gpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVertex;
        private System.Windows.Forms.Button btnAddvertex;
        private System.Windows.Forms.GroupBox gbEdge;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSecondNodeID;
        private System.Windows.Forms.TextBox txtFirstNodeID;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.GroupBox gbSelections;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lboEdges;
        private System.Windows.Forms.ListBox lboVertexes;
        private System.Windows.Forms.Button btnSetSource;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblVertices;
        private System.Windows.Forms.GroupBox gpResults;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnDeleteEdge;
        private System.Windows.Forms.Button btnDeleteVertex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboLowestCostPath;
    }
}

