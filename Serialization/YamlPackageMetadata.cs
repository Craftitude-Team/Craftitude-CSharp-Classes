using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using YaTools.Yaml;
using YaTools.Yaml.AbstractContracts;

namespace Craftitude
{
    public class YamlPackageMetadata
    {
        /// <summary>
        /// The package's ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// The package name, also considered the title
        /// of the content.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of the package
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A list of all package maintainers
        /// </summary>
        public string[] Maintainers { get; set; }

        /// <summary>
        /// A list of all package content and/or package developers
        /// </summary>
        public string[] Developers { get; set; }

        /// <summary>
        /// The license info as-is in the YAML file
        /// </summary>
        public string License { get; set; }

        /// <summary>
        /// The license name or text if given
        /// </summary>
        public string LicenseNameOrText { get { return string.Join("; ", License.Split(new string[] { "; " }, StringSplitOptions.RemoveEmptyEntries).Where(licenseEntry => !Uri.IsWellFormedUriString(licenseEntry, UriKind.Absolute))); } }

        /// <summary>
        /// The license URL if given
        /// </summary>
        public string LicenseUrl { get { return License.Split(new string[] { "; " }, StringSplitOptions.RemoveEmptyEntries).SingleOrDefault(licenseEntry => Uri.IsWellFormedUriString(licenseEntry, UriKind.Absolute)); } }

        /// <summary>
        /// Indicates whether a package is platform-dependent.
        /// </summary>
        public bool PlatformDependence { get; set; }

        /// <summary>
        /// The ISO 8601-formatted timestamp of the package version's publishing.
        /// </summary>
        public string UpdateTimestamp { get; set; }
    }

}
