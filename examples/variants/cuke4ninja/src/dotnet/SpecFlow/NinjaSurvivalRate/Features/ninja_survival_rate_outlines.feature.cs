// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.4.0.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

#region Designer generated code

using TechTalk.SpecFlow;

namespace NinjaSurvivalRate.Features
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Fight or flight with outlines")]
    public partial class FightOrFlightWithOutlinesFeature
    {
        private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "ninja_survival_rate_outlines.feature"
#line hidden

        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            var featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"),
                                                                "Fight or flight with outlines",
                                                                "In order to increase the ninja survival rate,\nAs a ninja commander\nI want my ninj" +
                                                                "as to decide whether to take on an\nopponent based on their skill levels",
                                                                GenerationTargetLanguage.CSharp, ((string[]) (null)));
            testRunner.OnFeatureStart(featureInfo);
        }

        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }

        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }

        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }

        public virtual void Third_LevelNinjasEngageSamurai(string beltLevel, string opponent, string expectedAction)
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("third-level ninjas engage samurai",
                                                                  ((string[]) (null)));
#line 7
            this.ScenarioSetup(scenarioInfo);
#line 8
            testRunner.Given(string.Format("the ninja has a {0} level black-belt", beltLevel));
#line 9
            testRunner.When(string.Format("attacked by {0}", opponent));
#line 10
            testRunner.Then(string.Format("the ninja should {0}", expectedAction));
#line hidden
            testRunner.CollectScenarioErrors();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("third-level ninjas engage samurai")]
        public virtual void Third_LevelNinjasEngageSamurai_Variant0()
        {
            this.Third_LevelNinjasEngageSamurai("third", "a samurai", "engage the opponent");
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("third-level ninjas engage samurai")]
        public virtual void Third_LevelNinjasEngageSamurai_Variant1()
        {
            this.Third_LevelNinjasEngageSamurai("third", "Chuck Norris", "run for his life");
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("third-level ninjas engage samurai")]
        public virtual void Third_LevelNinjasEngageSamurai_Variant2()
        {
            this.Third_LevelNinjasEngageSamurai("second", "a samurai", "run for his life");
        }
    }
}

#endregion