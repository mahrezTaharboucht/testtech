namespace Client
{
    partial class ClientUI
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFibonacci = new System.Windows.Forms.Button();
            this.btnXmlToJson = new System.Windows.Forms.Button();
            this.txtXml = new System.Windows.Forms.TextBox();
            this.txtFibonacci = new System.Windows.Forms.TextBox();
            this.lblFibonacci = new System.Windows.Forms.Label();
            this.fibonancciPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblXml = new System.Windows.Forms.Label();
            this.fibonancciPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFibonacci
            // 
            this.btnFibonacci.BackColor = System.Drawing.SystemColors.Control;
            this.btnFibonacci.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFibonacci.Location = new System.Drawing.Point(438, 61);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new System.Drawing.Size(217, 35);
            this.btnFibonacci.TabIndex = 0;
            this.btnFibonacci.Text = "Compute Fibonacci";
            this.btnFibonacci.UseVisualStyleBackColor = false;
            this.btnFibonacci.Click += new System.EventHandler(this.btnFibonacci_Click);
            // 
            // btnXmlToJson
            // 
            this.btnXmlToJson.Location = new System.Drawing.Point(435, 62);
            this.btnXmlToJson.Name = "btnXmlToJson";
            this.btnXmlToJson.Size = new System.Drawing.Size(217, 38);
            this.btnXmlToJson.TabIndex = 1;
            this.btnXmlToJson.Text = "Convert Xml To Json";
            this.btnXmlToJson.UseVisualStyleBackColor = true;
            this.btnXmlToJson.Click += new System.EventHandler(this.btnXmlToJson_Click);
            // 
            // txtXml
            // 
            this.txtXml.Location = new System.Drawing.Point(178, 5);
            this.txtXml.Multiline = true;
            this.txtXml.Name = "txtXml";
            this.txtXml.Size = new System.Drawing.Size(474, 50);
            this.txtXml.TabIndex = 2;
            this.txtXml.Text = "<foo>bar</foo>";
            // 
            // txtFibonacci
            // 
            this.txtFibonacci.Location = new System.Drawing.Point(150, 25);
            this.txtFibonacci.Name = "txtFibonacci";
            this.txtFibonacci.Size = new System.Drawing.Size(58, 26);
            this.txtFibonacci.TabIndex = 3;
            this.txtFibonacci.Text = "10";
            this.txtFibonacci.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFibonacci
            // 
            this.lblFibonacci.AutoSize = true;
            this.lblFibonacci.Location = new System.Drawing.Point(17, 31);
            this.lblFibonacci.Name = "lblFibonacci";
            this.lblFibonacci.Size = new System.Drawing.Size(127, 20);
            this.lblFibonacci.TabIndex = 4;
            this.lblFibonacci.Text = "Enter a number :";
            // 
            // fibonancciPanel
            // 
            this.fibonancciPanel.BackColor = System.Drawing.SystemColors.Control;
            this.fibonancciPanel.Controls.Add(this.btnFibonacci);
            this.fibonancciPanel.Controls.Add(this.txtFibonacci);
            this.fibonancciPanel.Controls.Add(this.lblFibonacci);
            this.fibonancciPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fibonancciPanel.Location = new System.Drawing.Point(12, 28);
            this.fibonancciPanel.Name = "fibonancciPanel";
            this.fibonancciPanel.Size = new System.Drawing.Size(655, 99);
            this.fibonancciPanel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblXml);
            this.panel1.Controls.Add(this.txtXml);
            this.panel1.Controls.Add(this.btnXmlToJson);
            this.panel1.Location = new System.Drawing.Point(12, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 100);
            this.panel1.TabIndex = 7;
            // 
            // lblXml
            // 
            this.lblXml.AutoSize = true;
            this.lblXml.Location = new System.Drawing.Point(17, 35);
            this.lblXml.Name = "lblXml";
            this.lblXml.Size = new System.Drawing.Size(156, 20);
            this.lblXml.TabIndex = 3;
            this.lblXml.Text = "Enter an Xml string : ";
        
            // 
            // ClientUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 283);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fibonancciPanel);
            this.Name = "ClientUI";
            this.Text = "Client";
            this.fibonancciPanel.ResumeLayout(false);
            this.fibonancciPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFibonacci;
        private System.Windows.Forms.Button btnXmlToJson;
        private System.Windows.Forms.TextBox txtXml;
        private System.Windows.Forms.TextBox txtFibonacci;
        private System.Windows.Forms.Label lblFibonacci;
        private System.Windows.Forms.Panel fibonancciPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblXml;
    }
}

