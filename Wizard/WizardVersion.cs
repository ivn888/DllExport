// This code was generated by a vsSolutionBuildEvent. 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
namespace net.r_eg.DllExport.Wizard
{
    using System;

    internal struct WizardVersion
    {
        public static readonly Version number = new Version(S_NUM_REV);

        public const string S_NUM = "1.6.0";
        public const string S_REV = "9361";
        public const string S_REL = "beta2";

        public const string S_NUM_REV = S_NUM + "." + S_REV;

        public const string BRANCH_SHA1 = "-";
        public const string BRANCH_NAME = "-";
        public const string BRANCH_REVC = "-";

        internal const string S_INFO        = S_NUM_REV + " " + S_REL + " [ " + BRANCH_SHA1 + " ]";
        internal const string S_INFO_FULL   = S_INFO + " /'" + BRANCH_NAME + "':" + BRANCH_REVC;
    }
}