using Core.Applications.CommandProcessing;
using Core.Computers;
using Core.Monads;
using static Core.Monads.MonadFunctions;

namespace FFind
{
   public class Program : CommandProcessor
   {
      public static void Main(string[] args)
      {
         var program = new Program("FFind");
      }

      public Program(string application) : base(application)
      {
      }

      public override void Initialize()
      {
         Folder = none<FolderName>();
         File = none<FileName>();
      }

      [Command("find"), CommandHelp("Finds text by pattern","folder?", "file?")]
      public void Find()
      {
         if (Folder.If(out var folder))
         {

         }
         else if (File.If(out var file))
         {

         }
         else
         {

         }
      }

      [Switch("pattern"), ShortCut("p"), SwitchHelp("pattern")]
      public string Pattern { get; set; }

      [Switch("folder"), ShortCut("F"), SwitchHelp("folder")]
      public Maybe<FolderName> Folder { get; set; }

      [Switch("file"), ShortCut("f"), SwitchHelp("file")]
      public Maybe<FileName> File { get; set; }
   }
}
