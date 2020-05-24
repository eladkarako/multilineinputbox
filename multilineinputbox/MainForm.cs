/*
 * Created by SharpDevelop.
 * User: Elad
 * Date: 24/05/2020
 * Time: 00:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;


namespace multilineinputbox
{
  
  /// <summary>
  /// Description of MainForm.
  /// </summary>
  public partial class MainForm : Form
  {
    public MainForm()
    {
      //
      // The InitializeComponent() call is required for Windows Forms designer support.
      //
      InitializeComponent();
      
      //
      // TODO: Add constructor code after the InitializeComponent() call.
      //
    }
    
    void Button1Click(object sender, EventArgs e){ //user clicked ok.
      Encoding utf8_no_bom     = new System.Text.UTF8Encoding(false);
      StreamWriter writer_out  = new StreamWriter(Console.OpenStandardOutput(),utf8_no_bom);
      writer_out.Write(this.textBox2.Text);
      writer_out.Flush();
      writer_out.Close();
      
      Environment.ExitCode = 0; //"OK".
      this.Close();
    }
    void Button2Click(object sender, EventArgs e){ //user clicked cancel.
      Encoding utf8_no_bom     = new System.Text.UTF8Encoding(false);
      StreamWriter writer_out  = new StreamWriter(Console.OpenStandardOutput(),utf8_no_bom);
      writer_out.Write("");
      writer_out.Flush();
      writer_out.Close();
      
      Environment.ExitCode = 1; //"Cancel".
      this.Close();
    }

    
  }
}
