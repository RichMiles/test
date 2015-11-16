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
                repository.GetPathTypeById(PathType_LandingPageId),
                null,
                null));
            return paths;
        }
        #endregion

        #region Path Landing Pages
        static Guid PathLandingPage_LandingPageAId { get; set; } = Guid.Parse("3997328E-5213-4FC5-8BF5-F4BF08924E95");
        static Guid PathLandingPage_LandingPageBId { get; set; } = Guid.Parse("6A725CD5-2D41-4EF6-9C81-4AFC5C2FD39D");

        #endregion

        #region Path Types
        static Guid PathType_LandingPageId { get; set; } = Guid.Parse("6794253D-8CCE-44C4-877B-C60D193038CF");
        static Guid PathType_OfferPageId { get; set; } = Guid.Parse("CA6E07D7-8EE1-4A47-9814-4966BEF66186");
        static Guid PathType_SurveyId { get; set; } = Guid.Parse("FE0FC2EE-6E8C-45E1-97A0-FF4ACC291079");

        public static IEnumerable<PathTypeModel> BuildStandardPathTypes()
        {
            List<PathTypeModel> pathTypes = new List<PathTypeModel>();
            pathTypes.Add(PathTypeModel.Build(PathType_LandingPageId, "Landing Page Only"));
            pathTypes.Add(PathTypeModel.Build(PathType_OfferPageId, "Offer Page"));
            pathTypes.Add(PathTypeModel.Build(PathType_SurveyId, "Survey"));
            return pathTypes;
        }
        #endregion
    }
}
