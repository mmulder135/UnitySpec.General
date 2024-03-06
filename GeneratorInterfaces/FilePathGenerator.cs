﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UnityFlow.General.GeneratorInterfaces
{
    public class FilePathGenerator
    {
        public string GenerateFilePath(string projectFolder, string relativeOutputPath, string featureFileName, string generatedCodeBehindFileName)
        {
            if (projectFolder is null)
            {
                throw new ArgumentNullException(nameof(projectFolder));
            }

            if (featureFileName is null)
            {
                throw new ArgumentNullException(nameof(featureFileName));
            }

            if (generatedCodeBehindFileName is null)
            {
                throw new ArgumentNullException(nameof(generatedCodeBehindFileName));
            }

            string featureFileFullPath = Path.GetFullPath(Path.Combine(projectFolder, relativeOutputPath ?? "", featureFileName));
            string featureFileDirPath = Path.GetDirectoryName(featureFileFullPath);

            return Path.Combine(featureFileDirPath, generatedCodeBehindFileName);
        }
    }
}
