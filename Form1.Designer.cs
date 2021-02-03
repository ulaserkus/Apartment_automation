
namespace Apartment_automation
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_income = new System.Windows.Forms.Button();
            this.btn_cost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_income
            // 
            this.btn_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_income.Location = new System.Drawing.Point(129, 33);
            this.btn_income.Name = "btn_income";
            this.btn_income.Size = new System.Drawing.Size(146, 269);
            this.btn_income.TabIndex = 0;
            this.btn_income.Text = "Gelirler";
            this.btn_income.UseVisualStyleBackColor = true;
            this.btn_income.Click += new System.EventHandler(this.btn_income_Click);
            // 
            // btn_cost
            // 
            this.btn_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cost.Location = new System.Drawing.Point(404, 33);
            this.btn_cost.Name = "btn_cost";
            this.btn_cost.Size = new System.Drawing.Size(146, 269);
            this.btn_cost.TabIndex = 1;
            this.btn_cost.Text = "Giderler";
            this.btn_cost.UseVisualStyleBackColor = true;
            this.btn_cost.Click += new System.EventHandler(this.btn_cost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 337);
            this.Controls.Add(this.btn_cost);
            this.Controls.Add(this.btn_income);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_income;
        private System.Windows.Forms.Button btn_cost;
    }
}

