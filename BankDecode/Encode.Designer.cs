namespace BankDecode
{
    partial class Encode
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encode));
            this.gboxCgb = new System.Windows.Forms.GroupBox();
            this.radioCgbTest = new System.Windows.Forms.RadioButton();
            this.radioCgbProd = new System.Windows.Forms.RadioButton();
            this.txtOriginCgb = new System.Windows.Forms.TextBox();
            this.btnEncodeCgb = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOriginBosc = new System.Windows.Forms.TextBox();
            this.radioBoscProd = new System.Windows.Forms.RadioButton();
            this.radioBoscTest = new System.Windows.Forms.RadioButton();
            this.btnDecodeCgb = new System.Windows.Forms.Button();
            this.btnDecodeBosc = new System.Windows.Forms.Button();
            this.btnEncodeBosc = new System.Windows.Forms.Button();
            this.txtTargetBosc = new System.Windows.Forms.TextBox();
            this.txtTargetCgb = new System.Windows.Forms.TextBox();
            this.gboxCgb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxCgb
            // 
            this.gboxCgb.Controls.Add(this.txtTargetCgb);
            this.gboxCgb.Controls.Add(this.btnDecodeCgb);
            this.gboxCgb.Controls.Add(this.btnEncodeCgb);
            this.gboxCgb.Controls.Add(this.txtOriginCgb);
            this.gboxCgb.Controls.Add(this.radioCgbProd);
            this.gboxCgb.Controls.Add(this.radioCgbTest);
            this.gboxCgb.Location = new System.Drawing.Point(12, 28);
            this.gboxCgb.Name = "gboxCgb";
            this.gboxCgb.Size = new System.Drawing.Size(776, 187);
            this.gboxCgb.TabIndex = 0;
            this.gboxCgb.TabStop = false;
            this.gboxCgb.Text = "广发银行";
            // 
            // radioCgbTest
            // 
            this.radioCgbTest.AutoSize = true;
            this.radioCgbTest.Location = new System.Drawing.Point(589, 50);
            this.radioCgbTest.Name = "radioCgbTest";
            this.radioCgbTest.Size = new System.Drawing.Size(71, 16);
            this.radioCgbTest.TabIndex = 0;
            this.radioCgbTest.Text = "测试环境";
            this.radioCgbTest.UseVisualStyleBackColor = true;
            // 
            // radioCgbProd
            // 
            this.radioCgbProd.AutoSize = true;
            this.radioCgbProd.Checked = true;
            this.radioCgbProd.Location = new System.Drawing.Point(689, 50);
            this.radioCgbProd.Name = "radioCgbProd";
            this.radioCgbProd.Size = new System.Drawing.Size(71, 16);
            this.radioCgbProd.TabIndex = 1;
            this.radioCgbProd.TabStop = true;
            this.radioCgbProd.Text = "生产环境";
            this.radioCgbProd.UseVisualStyleBackColor = true;
            // 
            // txtOriginCgb
            // 
            this.txtOriginCgb.Location = new System.Drawing.Point(23, 31);
            this.txtOriginCgb.Multiline = true;
            this.txtOriginCgb.Name = "txtOriginCgb";
            this.txtOriginCgb.Size = new System.Drawing.Size(547, 62);
            this.txtOriginCgb.TabIndex = 2;
            // 
            // btnEncodeCgb
            // 
            this.btnEncodeCgb.Location = new System.Drawing.Point(588, 104);
            this.btnEncodeCgb.Name = "btnEncodeCgb";
            this.btnEncodeCgb.Size = new System.Drawing.Size(81, 32);
            this.btnEncodeCgb.TabIndex = 3;
            this.btnEncodeCgb.Text = "加密";
            this.btnEncodeCgb.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTargetBosc);
            this.groupBox1.Controls.Add(this.btnDecodeBosc);
            this.groupBox1.Controls.Add(this.btnEncodeBosc);
            this.groupBox1.Controls.Add(this.txtOriginBosc);
            this.groupBox1.Controls.Add(this.radioBoscProd);
            this.groupBox1.Controls.Add(this.radioBoscTest);
            this.groupBox1.Location = new System.Drawing.Point(12, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 188);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "上海银行";
            // 
            // txtOriginBosc
            // 
            this.txtOriginBosc.Location = new System.Drawing.Point(23, 31);
            this.txtOriginBosc.Multiline = true;
            this.txtOriginBosc.Name = "txtOriginBosc";
            this.txtOriginBosc.Size = new System.Drawing.Size(547, 65);
            this.txtOriginBosc.TabIndex = 2;
            // 
            // radioBoscProd
            // 
            this.radioBoscProd.AutoSize = true;
            this.radioBoscProd.Checked = true;
            this.radioBoscProd.Location = new System.Drawing.Point(689, 50);
            this.radioBoscProd.Name = "radioBoscProd";
            this.radioBoscProd.Size = new System.Drawing.Size(71, 16);
            this.radioBoscProd.TabIndex = 1;
            this.radioBoscProd.TabStop = true;
            this.radioBoscProd.Text = "生产环境";
            this.radioBoscProd.UseVisualStyleBackColor = true;
            // 
            // radioBoscTest
            // 
            this.radioBoscTest.AutoSize = true;
            this.radioBoscTest.Location = new System.Drawing.Point(589, 50);
            this.radioBoscTest.Name = "radioBoscTest";
            this.radioBoscTest.Size = new System.Drawing.Size(71, 16);
            this.radioBoscTest.TabIndex = 0;
            this.radioBoscTest.Text = "测试环境";
            this.radioBoscTest.UseVisualStyleBackColor = true;
            // 
            // btnDecodeCgb
            // 
            this.btnDecodeCgb.Location = new System.Drawing.Point(678, 104);
            this.btnDecodeCgb.Name = "btnDecodeCgb";
            this.btnDecodeCgb.Size = new System.Drawing.Size(81, 32);
            this.btnDecodeCgb.TabIndex = 4;
            this.btnDecodeCgb.Text = "解密";
            this.btnDecodeCgb.UseVisualStyleBackColor = true;
            // 
            // btnDecodeBosc
            // 
            this.btnDecodeBosc.Location = new System.Drawing.Point(678, 100);
            this.btnDecodeBosc.Name = "btnDecodeBosc";
            this.btnDecodeBosc.Size = new System.Drawing.Size(81, 32);
            this.btnDecodeBosc.TabIndex = 6;
            this.btnDecodeBosc.Text = "解密";
            this.btnDecodeBosc.UseVisualStyleBackColor = true;
            // 
            // btnEncodeBosc
            // 
            this.btnEncodeBosc.Location = new System.Drawing.Point(588, 100);
            this.btnEncodeBosc.Name = "btnEncodeBosc";
            this.btnEncodeBosc.Size = new System.Drawing.Size(81, 32);
            this.btnEncodeBosc.TabIndex = 5;
            this.btnEncodeBosc.Text = "加密";
            this.btnEncodeBosc.UseVisualStyleBackColor = true;
            // 
            // txtTargetBosc
            // 
            this.txtTargetBosc.Location = new System.Drawing.Point(23, 107);
            this.txtTargetBosc.Multiline = true;
            this.txtTargetBosc.Name = "txtTargetBosc";
            this.txtTargetBosc.Size = new System.Drawing.Size(547, 65);
            this.txtTargetBosc.TabIndex = 7;
            this.txtTargetBosc.Text = "存放结果数据";
            // 
            // txtTargetCgb
            // 
            this.txtTargetCgb.Location = new System.Drawing.Point(23, 109);
            this.txtTargetCgb.Multiline = true;
            this.txtTargetCgb.Name = "txtTargetCgb";
            this.txtTargetCgb.Size = new System.Drawing.Size(547, 62);
            this.txtTargetCgb.TabIndex = 5;
            this.txtTargetCgb.Text = "存放结果数据";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxCgb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "银行卡号加解密工具";
            this.gboxCgb.ResumeLayout(false);
            this.gboxCgb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxCgb;
        private System.Windows.Forms.Button btnEncodeCgb;
        private System.Windows.Forms.TextBox txtOriginCgb;
        private System.Windows.Forms.RadioButton radioCgbProd;
        private System.Windows.Forms.RadioButton radioCgbTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOriginBosc;
        private System.Windows.Forms.RadioButton radioBoscProd;
        private System.Windows.Forms.RadioButton radioBoscTest;
        private System.Windows.Forms.Button btnDecodeCgb;
        private System.Windows.Forms.Button btnDecodeBosc;
        private System.Windows.Forms.Button btnEncodeBosc;
        private System.Windows.Forms.TextBox txtTargetBosc;
        private System.Windows.Forms.TextBox txtTargetCgb;
    }
}

