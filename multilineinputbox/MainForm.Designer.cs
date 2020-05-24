/*
 * Created by SharpDevelop.
 * User: Elad
 * Date: 24/05/2020
 * Time: 00:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace multilineinputbox
{
  partial class MainForm
  {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox textBox2;
    
    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing) {
        if (components != null) {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }
    
    /// <summary>
    /// This method is required for Windows Forms designer support.
    /// Do not change the method contents inside the source code editor. The Forms designer might
    /// not be able to load this method if it was changed manually.
    /// </summary>
    private void InitializeComponent()
    {
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.AcceptsReturn = true;
      this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.textBox1.BackColor = System.Drawing.SystemColors.Control;
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F);
      this.textBox1.Location = new System.Drawing.Point(6, 5);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(478, 67);
      this.textBox1.TabIndex = 3;
      this.textBox1.Text = "Input Data: \r\nThe following text-area supports a multi-line input, \r\nincluding th" +
  "e [Enter]-key as input as well.";
      // 
      // button1
      // 
      this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
      this.button1.Location = new System.Drawing.Point(353, 227);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(133, 30);
      this.button1.TabIndex = 1;
      this.button1.Text = "OK";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1Click);
      // 
      // button2
      // 
      this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button2.Font = new System.Drawing.Font("Tahoma", 12F);
      this.button2.Location = new System.Drawing.Point(214, 227);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(133, 30);
      this.button2.TabIndex = 2;
      this.button2.Text = "Cancel";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.Button2Click);
      // 
      // textBox2
      // 
      this.textBox2.AcceptsReturn = true;
      this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.textBox2.BackColor = System.Drawing.SystemColors.Info;
      this.textBox2.Font = new System.Drawing.Font("Courier New", 12F);
      this.textBox2.Location = new System.Drawing.Point(6, 78);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox2.Size = new System.Drawing.Size(478, 143);
      this.textBox2.TabIndex = 0;
      this.textBox2.Text = "Silly Bunny!";
      // 
      // MainForm
      // 
      this.AcceptButton = this.button1;
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
      this.CancelButton = this.button2;
      this.ClientSize = new System.Drawing.Size(494, 261);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.Font = new System.Drawing.Font("Tahoma", 9.75F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.Opacity = 0.95D;
      this.Text = "Multiline InputBox";
      this.ResumeLayout(false);
      this.PerformLayout();

    }
  }
}
