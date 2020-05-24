/*
 * Created by SharpDevelop.
 * User: Elad
 * Date: 24/05/2020
 * Time: 00:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;
using System.Runtime.InteropServices;

namespace multilineinputbox
{
  /// <summary>
  /// Class with program entry point.
  /// </summary>
  public sealed class Program
  {
    
    /// <summary>
    /// Program entry point.
    /// </summary>
    [STAThread]
    public static void Main(string[] args)
    {
      Encoding utf8_no_bom = new System.Text.UTF8Encoding(false);
      Process.GetCurrentProcess().StartInfo.StandardErrorEncoding = utf8_no_bom;
      Process.GetCurrentProcess().StartInfo.StandardOutputEncoding =utf8_no_bom;


      Environment.ExitCode = 1; //since program may be closed any-time, default to "exit code" of error input, which marks the "Cancel" clicking. If OK was clicked the exit-code is pre-changed to 0 (success).
      
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }
    
  }
}
