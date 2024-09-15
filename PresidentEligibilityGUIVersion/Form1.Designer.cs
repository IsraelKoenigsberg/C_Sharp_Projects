namespace PresidentEligibilityGUIVersion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            titleLabel = new Label();
            chkNaturalBornCitizen = new CheckBox();
            txtAge = new TextBox();
            ageLabel = new Label();
            yearsInUSLabel = new Label();
            txtYearsLived = new TextBox();
            btnSubmit = new Button();
            lblResult = new Label();
            termsServedLabel = new Label();
            txtTermsServed = new TextBox();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(325, 48);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(130, 15);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "President Eligibility Test";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // chkNaturalBornCitizen
            // 
            chkNaturalBornCitizen.AutoSize = true;
            chkNaturalBornCitizen.Location = new Point(187, 74);
            chkNaturalBornCitizen.Name = "chkNaturalBornCitizen";
            chkNaturalBornCitizen.Size = new Size(132, 19);
            chkNaturalBornCitizen.TabIndex = 2;
            chkNaturalBornCitizen.Text = "Natural Born Citizen";
            chkNaturalBornCitizen.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(352, 113);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 3;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(182, 113);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(86, 15);
            ageLabel.TabIndex = 4;
            ageLabel.Text = "Enter your age:";
            // 
            // yearsInUSLabel
            // 
            yearsInUSLabel.AutoSize = true;
            yearsInUSLabel.Location = new Point(182, 154);
            yearsInUSLabel.Name = "yearsInUSLabel";
            yearsInUSLabel.Size = new Size(148, 15);
            yearsInUSLabel.TabIndex = 5;
            yearsInUSLabel.Text = "Enter years lived in the U.S.";
            // 
            // txtYearsLived
            // 
            txtYearsLived.Location = new Point(352, 151);
            txtYearsLived.Name = "txtYearsLived";
            txtYearsLived.Size = new Size(100, 23);
            txtYearsLived.TabIndex = 6;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(325, 224);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(148, 23);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Determine Eligibility";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(50, 250);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(700, 50);
            lblResult.TabIndex = 8;
            lblResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // termsServedLabel
            // 
            termsServedLabel.AutoSize = true;
            termsServedLabel.Location = new Point(186, 187);
            termsServedLabel.Name = "termsServedLabel";
            termsServedLabel.Size = new Size(168, 15);
            termsServedLabel.TabIndex = 9;
            termsServedLabel.Text = "Amount of prior terms served?";
            termsServedLabel.Click += label1_Click;
            // 
            // termsServedTextbox
            // 
            txtTermsServed.Location = new Point(352, 187);
            txtTermsServed.Name = "termsServedTextbox";
            txtTermsServed.Size = new Size(100, 23);
            txtTermsServed.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTermsServed);
            Controls.Add(termsServedLabel);
            Controls.Add(btnSubmit);
            Controls.Add(txtYearsLived);
            Controls.Add(yearsInUSLabel);
            Controls.Add(ageLabel);
            Controls.Add(txtAge);
            Controls.Add(chkNaturalBornCitizen);
            Controls.Add(titleLabel);
            Controls.Add(lblResult);
            Name = "Form1";
            Text = "President Eligibility Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.CheckBox chkNaturalBornCitizen;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label yearsInUSLabel;
        private System.Windows.Forms.TextBox txtYearsLived;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblResult;  // Label to show the result
        private Label termsServedLabel;
        private TextBox txtTermsServed;
    }
}
