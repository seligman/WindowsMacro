namespace KeysTestApp
{
    partial class ExampleForm
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
            this.components = new System.ComponentModel.Container();
            this.useSendKeys = new System.Windows.Forms.Button();
            this.useKeys = new System.Windows.Forms.Button();
            this.labelTicker = new System.Windows.Forms.Label();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // useSendKeys
            // 
            this.useSendKeys.Location = new System.Drawing.Point(35, 56);
            this.useSendKeys.Name = "useSendKeys";
            this.useSendKeys.Size = new System.Drawing.Size(177, 23);
            this.useSendKeys.TabIndex = 0;
            this.useSendKeys.Text = "Use Send Keys (in 10 seconds)";
            this.useSendKeys.UseVisualStyleBackColor = true;
            this.useSendKeys.Click += new System.EventHandler(this.useSendKeys_Click);
            // 
            // useKeys
            // 
            this.useKeys.Location = new System.Drawing.Point(35, 85);
            this.useKeys.Name = "useKeys";
            this.useKeys.Size = new System.Drawing.Size(177, 23);
            this.useKeys.TabIndex = 1;
            this.useKeys.Text = "Use Keys (in 10 seconds)";
            this.useKeys.UseVisualStyleBackColor = true;
            this.useKeys.Click += new System.EventHandler(this.useKeys_Click);
            // 
            // labelTicker
            // 
            this.labelTicker.AutoSize = true;
            this.labelTicker.Location = new System.Drawing.Point(63, 144);
            this.labelTicker.Name = "labelTicker";
            this.labelTicker.Size = new System.Drawing.Size(0, 13);
            this.labelTicker.TabIndex = 2;
            // 
            // timerTick
            // 
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // ExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelTicker);
            this.Controls.Add(this.useKeys);
            this.Controls.Add(this.useSendKeys);
            this.Name = "ExampleForm";
            this.Text = "Keys Test App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button useSendKeys;
        private System.Windows.Forms.Button useKeys;
        private System.Windows.Forms.Label labelTicker;
        private System.Windows.Forms.Timer timerTick;
    }
}

