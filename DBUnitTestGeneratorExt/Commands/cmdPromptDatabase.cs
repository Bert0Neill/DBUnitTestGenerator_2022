using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using DBUnitTestGeneratorExt.EditorUI;
using DBUnitTestGeneratorExt.Models;
using log4net;
using log4net.Config;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Task = System.Threading.Tasks.Task;

namespace DBUnitTestGeneratorExt
{
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class cmdPromptDatabase
    {

        //private ILog log;
        private ILog log = LogManager.GetLogger(typeof(cmdPromptDatabase));

        /// <summary>
        /// Command ID.
        /// </summary>
        public const int CommandId = 0x0100;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("13fa8374-83cc-484a-9e44-df8a684f6bfb");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        private readonly AsyncPackage package;
        private readonly OleMenuCommandService myCommandService;

        /// <summary>
        /// Initializes a new instance of the <see cref="cmdPromptDatabase"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        /// <param name="commandService">Command service to add command to, not null.</param>
        private cmdPromptDatabase(AsyncPackage package, OleMenuCommandService commandService)
        {
            try
            {
                this.package = package ?? throw new ArgumentNullException(nameof(package));
                commandService = commandService ?? throw new ArgumentNullException(nameof(commandService));

                log.Info("ctor cmdPromptDatabase");

                var menuCommandID = new CommandID(CommandSet, CommandId);
                var menuItem = new MenuCommand(this.Execute, menuCommandID);
                commandService.AddCommand(menuItem);

                myCommandService = commandService;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message + " Stack Trace: " + ex.StackTrace);
            }
        }


        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static cmdPromptDatabase Instance
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        private Microsoft.VisualStudio.Shell.IAsyncServiceProvider ServiceProvider
        {
            get
            {
                return this.package;
            }
        }

        /// <summary>
        /// Initializes the singleton instance of the command.
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        public static async Task InitializeAsync(AsyncPackage package)
        {
            // Switch to the main thread - the call to AddCommand in cmdPromptDatabase's constructor requires
            // the UI thread.
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

            OleMenuCommandService commandService = await package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
            Instance = new cmdPromptDatabase(package, commandService);
        }

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private void Execute(object sender, EventArgs e)
        {
            ThreadHelper.ThrowIfNotOnUIThread();

            IProjectProperties projectProperties = new ProjectProperties();
            DatabaseDetails dbdetails = new DatabaseDetails(projectProperties);
            dbdetails.ShowDialog();

            string message = String.Format(CultureInfo.CurrentCulture, "Inside {0}.MenuItemCallback()", this.GetType().FullName);
        }
      
    }
}
