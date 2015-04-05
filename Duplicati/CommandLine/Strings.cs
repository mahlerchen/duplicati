using Duplicati.Library.Localization.Short;
namespace Duplicati.CommandLine.Strings {
    internal static class Program {
        public static string DeleteCommandNeedsOptions(string commandname, string[] options) { return LC.L(@"The command {0} needs at least one of the following options set: {1}", commandname, string.Join(", ", options)); }
        public static string WrongNumberOfCommandsError_v2(int actualcommands, int expectedcommands, string[] commands) { return LC.L(@"Found {0} commands but expected {1}, commands: 
{2}", actualcommands, expectedcommands, commands); }
        public static string InvalidCommandError(string commandname) { return LC.L(@"Command not supported: {0}", commandname); }
        public static string NoFilesetsMatching { get { return LC.L(@"No filesets matched the criteria"); } }
        public static string WouldDeleteBackups { get { return LC.L(@"The following filesets would be deleted:"); } }
        public static string DeletedBackups { get { return LC.L(@"These filesets were deleted:"); } }
        public static string SupportedBackendsHeader { get { return LC.L(@"Supported backends:"); } }
        public static string SupportedCompressionModulesHeader { get { return LC.L(@"Supported compression modules:"); } }
        public static string SupportedEncryptionModulesHeader { get { return LC.L(@"Supported encryption modules:"); } }
        public static string SupportedOptionsHeader { get { return LC.L(@"Supported options:"); } }
        public static string ModuleIsLoadedAutomatically { get { return LC.L(@"Module is loaded atomatically, use --disable-module to prevent this"); } }
        public static string ModuleIsNotLoadedAutomatically { get { return LC.L(@"Module is not loaded atomatically, use --enable-module to load it"); } }
        public static string GenericModulesHeader { get { return LC.L(@"Supported generic modules:"); } }
        public static string FailedToParseParametersFileError(string path, string message) { return LC.L(@"Unable to read the parameters file ""{0}"", reason: {1}", path, message); }
        public static string FiltersCannotBeUsedWithFileError { get { return LC.L(@"Filters cannot be specified on the commandline if filters are also present in the parameter file"); } }
        public static string InternalOptionUsedError(string optionname) { return LC.L(@"The option --{0} was supplied, but it is reserved for internal use and may not be set on the commandline", optionname); }
        public static string ParametersFileOptionLong { get { return LC.L(@"This option can be used to store some or all of the options given to the commandline client. The file must be a plain text file, UTF-8 encoding is preferred. Each line in the file should be of the format --option=value. The special options --source and --target can be used to override the localpath and the remote destination uri, respectively. The options in this file take precedence over the options provided on the commandline. You cannot specify filters in both the file and on the commandline."); } }
        public static string ParametersFileOptionShort { get { return LC.L(@"Path to a file with parameters"); } }
        public static string UnhandledException(string message) { return LC.L(@"An error occured: {0}", message); }
        public static string UnhandledInnerException(string message) { return LC.L(@"The inner error message is: {0}", message); }
        public static string IncludeLong { get { return LC.L(@"Include files that match this filter. The special character * means any number of character, and the special character ? means any single character, use *.txt to include all files with a txt extension. Regular expressions are also supported and can be supplied by using hard braces, i.e. [.*\.txt]."); } }
        public static string IncludeShort { get { return LC.L(@"Include files"); } }
        public static string ExcludeLong { get { return LC.L(@"Exclude files that match this filter. The special character * means any number of character, and the special character ? means any single character, use *.txt to include all files with a txt extension. Regular expressions are also supported and can be supplied by using hard braces, i.e. [.*\.txt]."); } }
        public static string ExcludeShort { get { return LC.L(@"Exclude files"); } }
        public static string ControlFilesOptionShort { get { return LC.L(@"If this option is used with a backup operation, it is interpreted as a list of files to add to the filesets. When used with list or restore, it will list or restore the control files instead of the normal files."); } }
        public static string ControlFilesOptionLong { get { return LC.L(@"Use control files"); } }
        public static string QuietConsoleOptionLong { get { return LC.L(@"If this option is set, progress reports and other messages that would normally go to the console will be redirected to the log."); } }
        public static string QuietConsoleOptionShort { get { return LC.L(@"Disable console output"); } }
    }
}