using Sample.Debugging;

namespace Sample
{
    public class SampleConsts
    {
        public const string LocalizationSourceName = "Sample";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "87097f5420ca4b78ac04cf9670dc2995";
    }
}
