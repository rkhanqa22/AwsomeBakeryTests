﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowProject1.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("GET Request Validation")]
    public partial class GETRequestValidationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "GetRequestBakeryOrder.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "GET Request Validation", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validate successfull status code")]
        [NUnit.Framework.CategoryAttribute("ResponseStatusValidation")]
        [NUnit.Framework.TestCaseAttribute("1", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("2", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("3", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("4", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("5", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("6", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("7", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("8", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("9", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("10", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("11", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("12", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("13", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("14", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("15", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("16", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("17", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("18", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("19", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("20", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("21", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("22", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("23", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("24", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("25", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("26", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("27", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("28", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("29", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("30", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("21", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("22", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("23", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("24", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("25", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("26", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("27", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("28", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("29", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("30", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("31", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("32", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("33", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("34", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("35", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("36", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("37", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("38", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("39", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("40", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("41", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("42", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("43", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("44", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("45", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("46", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("47", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("48", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("49", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("50", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("1000", "InternalServerError", null)]
        public virtual void ValidateSuccessfullStatusCode(string id, string statusCode, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ResponseStatusValidation"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("id", id);
            argumentsOfScenario.Add("statusCode", statusCode);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate successfull status code", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 testRunner.When(string.Format("Client able to send request with {0}", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 6
 testRunner.Then(string.Format("successful {0} is recieved", statusCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validate response content from the client")]
        [NUnit.Framework.CategoryAttribute("ResponseContentValidation")]
        [NUnit.Framework.TestCaseAttribute("1", "\"Caleigh_Cruickshank1@gmail.com\"", "99.00", "\"Intelligent Frozen Fish\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("2", "\"Harry8@yahoo.com\"", "605.00", "\"Awesome Metal Computer\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("3", "\"Ines_Miller@gmail.com\"", "72.00", "\"Electronic Concrete Shoes\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("4", "\"Mittie72@gmail.com\"", "536.00", "\"Luxurious Fresh Keyboard\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("5", "\"Caleigh_Cruickshank1@gmail.com\"", "100.00", "\"TEST CAKE\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("6", "\"Jett_Considine69@yahoo.com\"", "564.00", "\"Luxurious Wooden Computer\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("7", "\"Dayna.Swaniawski85@hotmail.com\"", "364.00", "\"Incredible Concrete Soap\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("8", "\"Emelie23@yahoo.com\"", "4.00", "\"Intelligent Bronze Table\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("9", "\"Danika68@hotmail.com\"", "76.00", "\"Rustic Wooden Keyboard\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("10", "\"Ellie90@hotmail.com\"", "836.00", "\"Modern Steel Table\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("11", "\"Donavon.Upton@gmail.com\"", "163.00", "\"Ergonomic Fresh Towels\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("12", "\"Uriel50@gmail.com\"", "448.00", "\"Handcrafted Fresh Shoes\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("13", "\"Roderick.Bednar50@hotmail.com\"", "387.00", "\"Practical Rubber Keyboard\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("14", "\"Dedric_Berge@gmail.com\"", "831.00", "\"Tasty Steel Fish\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("15", "\"Jaida50@yahoo.com\"", "331.00", "\"Elegant Cotton Chicken\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("16", "\"Richard_Ward@yahoo.com\"", "100.00", "\"Generic Metal Bacon\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("17", "\"Julien66@hotmail.com\"", "279.00", "\"Unbranded Concrete Bacon\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("18", "\"Ashleigh.Kertzmann@yahoo.com\"", "407.00", "\"Handcrafted Concrete Table\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("19", "\"Jules42@hotmail.com\"", "913.00", "\"Gorgeous Wooden Keyboard\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("20", "\"Kenna_Kreiger99@yahoo.com\"", "395.00", "\"Oriental Plastic Chicken\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("21", "\"Keith62@yahoo.com\"", "961.00", "\"Incredible Metal Computer\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("22", "\"Zetta52@yahoo.com\"", "231.00", "\"Practical Granite Pants\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("23", "\"Bennie_Schuppe51@hotmail.com\"", "979.00", "\"Oriental Plastic Chicken\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("24", "\"Deonte.Bogisich@yahoo.com\"", "322.00", "\"Electronic Metal Shoes\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("25", "\"Amelie.Hauck29@gmail.com\"", "635.00", "\"Awesome Wooden Bike\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("26", "\"Beatrice_Runte@hotmail.com\"", "556.00", "\"Gorgeous Fresh Hat\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("27", "\"Delphine42@yahoo.com\"", "441.00", "\"Unbranded Concrete Fish\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("28", "\"Heath19@yahoo.com\"", "710.00", "\"Ergonomic Metal Chair\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("29", "\"Ayla.Kshlerin1@yahoo.com\"", "392.00", "\"Small Steel Gloves\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("30", "\"Kelly_Morar@yahoo.com\"", "861.00", "\"Handcrafted Concrete Gloves\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("31", "\"Armani_Gleason@hotmail.com\"", "514.00", "\"Modern Steel Shirt\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("32", "\"Laila_Bayer@hotmail.com\"", "738.00", "\"Bespoke Bronze Cheese\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("33", "\"Camilla21@gmail.com\"", "357.00", "\"Handcrafted Metal Mouse\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("34", "\"Betsy.Jerde@yahoo.com\"", "568.00", "\"Generic Fresh Tuna\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("35", "\"Neoma57@hotmail.com\"", "341.00", "\"Elegant Frozen Chair\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("36", "\"Georgette12@hotmail.com\"", "292.00", "\"Small Plastic Gloves\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("37", "\"Kobe_Mraz63@gmail.com\"", "774.00", "\"Awesome Plastic Chair\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("38", "\"Bert_Murray48@gmail.com\"", "942.00", "\"Modern Bronze Chair\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("39", "\"Marie15@gmail.com\"", "973.00", "\"Modern Granite Cheese\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("40", "\"Jaquan.Krajcik@yahoo.com\"", "334.00", "\"Elegant Soft Table\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("41", "\"Arnold_Shanahan71@hotmail.com\"", "346.00", "\"Oriental Cotton Ball\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("42", "\"Noah_Gleason31@hotmail.com\"", "454.00", "\"Luxurious Frozen Chips\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("43", "\"Priscilla.Dibbert59@gmail.com\"", "395.00", "\"Ergonomic Bronze Shoes\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("44", "\"Marguerite0@hotmail.com\"", "149.00", "\"Incredible Steel Chips\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("45", "\"Athena1@hotmail.com\"", "787.00", "\"Intelligent Concrete Soap\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("46", "\"Brisa_Miller19@hotmail.com\"", "92.00", "\"Awesome Wooden Car\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("47", "\"Karli.Nader@hotmail.com\"", "684.00", "\"Practical Bronze Shoes\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("48", "\"Otto24@hotmail.com\"", "232.00", "\"Fantastic Granite Bacon\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("49", "\"Lillian_Bergnaum@yahoo.com\"", "892.00", "\"Incredible Cotton Shoes\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("50", "\"Rasheed.DAmore58@gmail.com\"", "360.00", "\"Fantastic Granite Hat\"", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("51", "\"Amari18@yahoo.com\"", "432.00", "\"Generic Soft Bacon\"", "78912", "18", "1", null)]
        public virtual void ValidateResponseContentFromTheClient(string id, string clientEmail, string price, string cakeName, string id1, string price1, string quantity, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ResponseContentValidation"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("id", id);
            argumentsOfScenario.Add("clientEmail", clientEmail);
            argumentsOfScenario.Add("price", price);
            argumentsOfScenario.Add("cakeName", cakeName);
            argumentsOfScenario.Add("Id", id1);
            argumentsOfScenario.Add("Price", price1);
            argumentsOfScenario.Add("Quantity", quantity);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate response content from the client", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 73
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 74
 testRunner.When(string.Format("Client able to send request with {0}", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 75
 testRunner.Then(string.Format("client with {0} and {1} and {2} and {3} and {4} and {5} and {6} has been validted" +
                            "", id, clientEmail, price, cakeName, id1, price1, quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
