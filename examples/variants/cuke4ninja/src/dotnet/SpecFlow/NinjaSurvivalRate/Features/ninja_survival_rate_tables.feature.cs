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
    [NUnit.Framework.DescriptionAttribute("Fight or flight With Inline Example")]
    public partial class FightOrFlightWithInlineExampleFeature
    {
        private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "ninja_survival_rate_tables.feature"
#line hidden

        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            var featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"),
                                                                "Fight or flight With Inline Example",
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

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Fully armed")]
        public virtual void FullyArmed()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fully armed", ((string[]) (null)));
#line 7
            this.ScenarioSetup(scenarioInfo);
#line hidden
            var table1 = new TechTalk.SpecFlow.Table(new string[]
                                                         {
                                                             "belt_level",
                                                             "katana",
                                                             "sake",
                                                             "fought",
                                                             "magic"
                                                         });
            table1.AddRow(new string[]
                              {
                                  "third",
                                  "two",
                                  "three",
                                  "samurai",
                                  "five"
                              });
#line 8
            testRunner.Given("a ninja with the following experience", ((string) (null)), table1);
#line 11
            testRunner.When("attacked by a samurai");
#line 12
            testRunner.Then("the ninja should engage the opponent");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}

#endregion