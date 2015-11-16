using Neowire.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neowire.Test.Helper
{
    public static class TestRepositoryBuilder
    {
        public static INeowireRepository BuildStandardTestRepository()
        {
            var repository = new TestRepository();
            var pathTypes = BuildStandardPathTypes();
            foreach (var pathType in pathTypes)
            {
                repository.PathTypes.Add(pathType.Id, pathType);
            }

            var paths = BuildStandardPaths(repository);
            foreach (var path in paths)
            {
                repository.Paths.Add(path.Id, path);
            }
            return repository;
        }

        #region Paths
        static Guid Path_LandingPageGuid { get; set; } = Guid.Parse("5890C268-6837-4463-9886-7F11FB39CD04");
        public static IEnumerable<PathModel> BuildStandardPaths(INeowireRepository repository)
        {
            List<PathModel> paths = new List<PathModel>();
            paths.Add(PathModel.Build(
                Path_LandingPageGuid,
                "Landing Page Only Path",
                repository.GetPathTypeById(PathType_LandingPageGuid),
                null,
                null));
            return paths;
        }

        #endregion

        #region Path Types
        static Guid PathType_LandingPageGuid { get; set; } = Guid.Parse("6794253D-8CCE-44C4-877B-C60D193038CF");
        static Guid PathType_OfferPage { get; set; } = Guid.Parse("CA6E07D7-8EE1-4A47-9814-4966BEF66186");
        static Guid PathType_Survey { get; set; } = Guid.Parse("FE0FC2EE-6E8C-45E1-97A0-FF4ACC291079");

        public static IEnumerable<PathTypeModel> BuildStandardPathTypes()
        {
            List<PathTypeModel> pathTypes = new List<PathTypeModel>();
            pathTypes.Add(PathTypeModel.Build(PathType_LandingPageGuid, "Landing Page Only"));
            pathTypes.Add(PathTypeModel.Build(PathType_OfferPage, "Offer Page"));
            pathTypes.Add(PathTypeModel.Build(PathType_Survey, "Survey"));
            return pathTypes;
        }
        #endregion
    }
}
