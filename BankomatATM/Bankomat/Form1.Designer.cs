namespace Bankomat
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
            this.components = new System.ComponentModel.Container();
            this.lblEnterCard = new System.Windows.Forms.Label();
            this.txtEnterCard = new System.Windows.Forms.TextBox();
            this.lblEnterPin = new System.Windows.Forms.Label();
            this.txtEnterPin = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbEnterCard = new System.Windows.Forms.TabPage();
            this.lblAlert1 = new System.Windows.Forms.Label();
            this.lblAlert = new System.Windows.Forms.Label();
            this.btnEnterCard = new System.Windows.Forms.Button();
            this.tbWithdrawMoney = new System.Windows.Forms.TabPage();
            this.lblWithdrawAlert = new System.Windows.Forms.Label();
            this.btnWithdrawMoney = new System.Windows.Forms.Button();
            this.txtWithdrawAmount = new System.Windows.Forms.TextBox();
            this.lblWithdrawMoney = new System.Windows.Forms.Label();
            this.tbDeposit = new System.Windows.Forms.TabPage();
            this.lblDepositAlert = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.tbcheckBalance = new System.Windows.Forms.TabPage();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.txtCheckBalance = new System.Windows.Forms.TextBox();
            this.lblCheckBalance = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tbEnterCard.SuspendLayout();
            this.tbWithdrawMoney.SuspendLayout();
            this.tbDeposit.SuspendLayout();
            this.tbcheckBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterCard
            // 
            this.lblEnterCard.AutoSize = true;
            this.lblEnterCard.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEnterCard.Location = new System.Drawing.Point(32, 38);
            this.lblEnterCard.Name = "lblEnterCard";
            this.lblEnterCard.Size = new System.Drawing.Size(128, 16);
            this.lblEnterCard.TabIndex = 7;
            this.lblEnterCard.Text = "Podaj numer karty";
            // 
            // txtEnterCard
            // 
            this.txtEnterCard.Location = new System.Drawing.Point(35, 73);
            this.txtEnterCard.Name = "txtEnterCard";
            this.txtEnterCard.Size = new System.Drawing.Size(170, 22);
            this.txtEnterCard.TabIndex = 8;
            // 
            // lblEnterPin
            // 
            this.lblEnterPin.AutoSize = true;
            this.lblEnterPin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEnterPin.Location = new System.Drawing.Point(32, 132);
            this.lblEnterPin.Name = "lblEnterPin";
            this.lblEnterPin.Size = new System.Drawing.Size(116, 16);
            this.lblEnterPin.TabIndex = 9;
            this.lblEnterPin.Text = "Podaj numer PIN";
            // 
            // txtEnterPin
            // 
            this.txtEnterPin.Location = new System.Drawing.Point(35, 166);
            this.txtEnterPin.Name = "txtEnterPin";
            this.txtEnterPin.Size = new System.Drawing.Size(170, 22);
            this.txtEnterPin.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbEnterCard);
            this.tabControl1.Controls.Add(this.tbWithdrawMoney);
            this.tabControl1.Controls.Add(this.tbDeposit);
            this.tabControl1.Controls.Add(this.tbcheckBalance);
            this.tabControl1.Location = new System.Drawing.Point(44, 141);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 255);
            this.tabControl1.TabIndex = 11;
            // 
            // tbEnterCard
            // 
            this.tbEnterCard.Controls.Add(this.lblAlert1);
            this.tbEnterCard.Controls.Add(this.lblAlert);
            this.tbEnterCard.Controls.Add(this.btnEnterCard);
            this.tbEnterCard.Controls.Add(this.lblEnterCard);
            this.tbEnterCard.Controls.Add(this.txtEnterPin);
            this.tbEnterCard.Controls.Add(this.txtEnterCard);
            this.tbEnterCard.Controls.Add(this.lblEnterPin);
            this.tbEnterCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbEnterCard.Location = new System.Drawing.Point(4, 23);
            this.tbEnterCard.Name = "tbEnterCard";
            this.tbEnterCard.Padding = new System.Windows.Forms.Padding(3);
            this.tbEnterCard.Size = new System.Drawing.Size(583, 228);
            this.tbEnterCard.TabIndex = 0;
            this.tbEnterCard.Text = "Weryfikacja";
            this.tbEnterCard.UseVisualStyleBackColor = true;
            this.tbEnterCard.Click += new System.EventHandler(this.tbEnterCard_Click);
            // 
            // lblAlert1
            // 
            this.lblAlert1.AutoSize = true;
            this.lblAlert1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAlert1.Location = new System.Drawing.Point(317, 38);
            this.lblAlert1.Name = "lblAlert1";
            this.lblAlert1.Size = new System.Drawing.Size(0, 16);
            this.lblAlert1.TabIndex = 13;
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Location = new System.Drawing.Point(278, 38);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(0, 14);
            this.lblAlert.TabIndex = 12;
            // 
            // btnEnterCard
            // 
            this.btnEnterCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnterCard.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEnterCard.Location = new System.Drawing.Point(320, 155);
            this.btnEnterCard.Name = "btnEnterCard";
            this.btnEnterCard.Size = new System.Drawing.Size(131, 33);
            this.btnEnterCard.TabIndex = 11;
            this.btnEnterCard.Text = "Weryfikacja";
            this.btnEnterCard.UseVisualStyleBackColor = true;
            this.btnEnterCard.Click += new System.EventHandler(this.btnEnterCard_Click);
            // 
            // tbWithdrawMoney
            // 
            this.tbWithdrawMoney.Controls.Add(this.lblWithdrawAlert);
            this.tbWithdrawMoney.Controls.Add(this.btnWithdrawMoney);
            this.tbWithdrawMoney.Controls.Add(this.txtWithdrawAmount);
            this.tbWithdrawMoney.Controls.Add(this.lblWithdrawMoney);
            this.tbWithdrawMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbWithdrawMoney.Location = new System.Drawing.Point(4, 23);
            this.tbWithdrawMoney.Name = "tbWithdrawMoney";
            this.tbWithdrawMoney.Padding = new System.Windows.Forms.Padding(3);
            this.tbWithdrawMoney.Size = new System.Drawing.Size(583, 228);
            this.tbWithdrawMoney.TabIndex = 1;
            this.tbWithdrawMoney.Text = "Wypłata gotówki";
            this.tbWithdrawMoney.UseVisualStyleBackColor = true;
            // 
            // lblWithdrawAlert
            // 
            this.lblWithdrawAlert.AutoSize = true;
            this.lblWithdrawAlert.Location = new System.Drawing.Point(296, 47);
            this.lblWithdrawAlert.Name = "lblWithdrawAlert";
            this.lblWithdrawAlert.Size = new System.Drawing.Size(0, 14);
            this.lblWithdrawAlert.TabIndex = 3;
            // 
            // btnWithdrawMoney
            // 
            this.btnWithdrawMoney.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWithdrawMoney.Location = new System.Drawing.Point(55, 160);
            this.btnWithdrawMoney.Name = "btnWithdrawMoney";
            this.btnWithdrawMoney.Size = new System.Drawing.Size(130, 32);
            this.btnWithdrawMoney.TabIndex = 2;
            this.btnWithdrawMoney.Text = "Wykonaj operację";
            this.btnWithdrawMoney.UseVisualStyleBackColor = true;
            this.btnWithdrawMoney.Click += new System.EventHandler(this.btnWithdrawMoney_Click);
            // 
            // txtWithdrawAmount
            // 
            this.txtWithdrawAmount.Location = new System.Drawing.Point(46, 94);
            this.txtWithdrawAmount.Name = "txtWithdrawAmount";
            this.txtWithdrawAmount.Size = new System.Drawing.Size(152, 22);
            this.txtWithdrawAmount.TabIndex = 1;
            this.txtWithdrawAmount.TextChanged += new System.EventHandler(this.txtWithdrawAmount_TextChanged);
            // 
            // lblWithdrawMoney
            // 
            this.lblWithdrawMoney.AutoSize = true;
            this.lblWithdrawMoney.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWithdrawMoney.Location = new System.Drawing.Point(21, 47);
            this.lblWithdrawMoney.Name = "lblWithdrawMoney";
            this.lblWithdrawMoney.Size = new System.Drawing.Size(210, 16);
            this.lblWithdrawMoney.TabIndex = 0;
            this.lblWithdrawMoney.Text = "Ile pieniędzy chcesz wypłacić?";
            // 
            // tbDeposit
            // 
            this.tbDeposit.Controls.Add(this.lblDepositAlert);
            this.tbDeposit.Controls.Add(this.btnDeposit);
            this.tbDeposit.Controls.Add(this.txtDeposit);
            this.tbDeposit.Controls.Add(this.lblDeposit);
            this.tbDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbDeposit.Location = new System.Drawing.Point(4, 23);
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.Size = new System.Drawing.Size(583, 228);
            this.tbDeposit.TabIndex = 2;
            this.tbDeposit.Text = "Wpłata gotówki";
            this.tbDeposit.UseVisualStyleBackColor = true;
            // 
            // lblDepositAlert
            // 
            this.lblDepositAlert.AutoSize = true;
            this.lblDepositAlert.Location = new System.Drawing.Point(275, 36);
            this.lblDepositAlert.Name = "lblDepositAlert";
            this.lblDepositAlert.Size = new System.Drawing.Size(0, 14);
            this.lblDepositAlert.TabIndex = 4;
            // 
            // btnDeposit
            // 
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeposit.Location = new System.Drawing.Point(30, 153);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(156, 32);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Wykonaj operację";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(41, 76);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(133, 22);
            this.txtDeposit.TabIndex = 1;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDeposit.Location = new System.Drawing.Point(38, 34);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(136, 16);
            this.lblDeposit.TabIndex = 0;
            this.lblDeposit.Text = "Ile chcesz wpłacić?";
            // 
            // tbcheckBalance
            // 
            this.tbcheckBalance.Controls.Add(this.btnCheckBalance);
            this.tbcheckBalance.Controls.Add(this.txtCheckBalance);
            this.tbcheckBalance.Controls.Add(this.lblCheckBalance);
            this.tbcheckBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbcheckBalance.Location = new System.Drawing.Point(4, 23);
            this.tbcheckBalance.Name = "tbcheckBalance";
            this.tbcheckBalance.Size = new System.Drawing.Size(583, 228);
            this.tbcheckBalance.TabIndex = 3;
            this.tbcheckBalance.Text = "Stan konta";
            this.tbcheckBalance.UseVisualStyleBackColor = true;
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckBalance.Location = new System.Drawing.Point(52, 120);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(106, 42);
            this.btnCheckBalance.TabIndex = 2;
            this.btnCheckBalance.Text = "Sprawdź";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // txtCheckBalance
            // 
            this.txtCheckBalance.Location = new System.Drawing.Point(203, 45);
            this.txtCheckBalance.Name = "txtCheckBalance";
            this.txtCheckBalance.ReadOnly = true;
            this.txtCheckBalance.Size = new System.Drawing.Size(100, 22);
            this.txtCheckBalance.TabIndex = 1;
            // 
            // lblCheckBalance
            // 
            this.lblCheckBalance.AutoSize = true;
            this.lblCheckBalance.Location = new System.Drawing.Point(49, 48);
            this.lblCheckBalance.Name = "lblCheckBalance";
            this.lblCheckBalance.Size = new System.Drawing.Size(137, 14);
            this.lblCheckBalance.TabIndex = 0;
            this.lblCheckBalance.Text = "Stan twojego konta:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(264, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 33);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Bankomat";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 434);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Form1";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbEnterCard.ResumeLayout(false);
            this.tbEnterCard.PerformLayout();
            this.tbWithdrawMoney.ResumeLayout(false);
            this.tbWithdrawMoney.PerformLayout();
            this.tbDeposit.ResumeLayout(false);
            this.tbDeposit.PerformLayout();
            this.tbcheckBalance.ResumeLayout(false);
            this.tbcheckBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEnterCard;
        private System.Windows.Forms.TextBox txtEnterCard;
        private System.Windows.Forms.Label lblEnterPin;
        private System.Windows.Forms.TextBox txtEnterPin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbEnterCard;
        private System.Windows.Forms.TabPage tbWithdrawMoney;
        private System.Windows.Forms.TextBox txtWithdrawAmount;
        private System.Windows.Forms.Label lblWithdrawMoney;
        private System.Windows.Forms.Button btnEnterCard;
        private System.Windows.Forms.Button btnWithdrawMoney;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblAlert1;
        private System.Windows.Forms.TabPage tbDeposit;
        private System.Windows.Forms.TabPage tbcheckBalance;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.TextBox txtCheckBalance;
        private System.Windows.Forms.Label lblCheckBalance;
        private System.Windows.Forms.Label lblWithdrawAlert;
        private System.Windows.Forms.Label lblDepositAlert;
    }
}

