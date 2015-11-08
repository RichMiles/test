using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Neowire.Reporting.Test
{
    [TestClass]
    public class ReportingRevenue
    {

        [TestMethod]
        [TestCategory("Revenue Reporting")]
        public void ReportingRevenue_PageLoads_Visuals()
        {
            ///GWT 1
            /// - Given
            ///    -- I am (at this URL) 
            /// - When
            ///   -- The page loads
            /// - Then
            /// -- I will see a screen with a search criteria box, search fields, report column headers, and an "Export" button
            throw new NotImplementedException();
        }


        [TestMethod]
        [TestCategory("Revenue Reporting")]
        public void ReportingRevenue_ViewSearchCriteria_SearchCriteria()
        {
            /// GWT 2
            /// - Given
            /// -- I am (at this URL) 
            /// -When
            /// -- I view the Search Criteria
            /// - Then
            /// -- I will see the following:
            ///            ---Date
            ///            ---- There will be "Start Date" and "End Date" fields
            ///            ---- These fields will be required
            ///            ---- Valid date format is MM / DD / YYYY
            ///            ---- They will be calendar pop - ups(when user clicks the box, a calendar will pop up)
            ///            ---- The Start Date and End Date will default to current date
            /// ---Path Name
            ///---- This will be a text field
            /// ----This is not a required field
            ///---- This field will be blank by default
            /// ---- This will not be an auto-fill.Searches will filter by path names that include the string in this field
            ///-- - Publisher
            ///---- This will be a text field
            /// ----This is not a required field
            ///---- This field will be blank by default
            /// ---- This will not be an auto-fill.Searches will filter by path names that include the string in this field
            ///-- - Country
            ///---- This will be a drop down
            /// ----This is not a required field
            ///---- Drop - down will consist of "All", "Sweden", and "Norway"
            ///  ---- - We will likely add a couple more countries over time
            ///   ---- Drop - down will default to "All"
            ///     -- - A Submit button
            throw new NotImplementedException();
        }


        [TestMethod]
        [TestCategory("Revenue Reporting")]
        public void ReportingRevenue_ValidDateSubmit_Results()
        {
            // GWT 3
            // - Given
            // -- There are dates in the Start Date and End Date fields
            // - When
            // -- I press the Submit button
            // - Then
            // -- Results will populate in the table below
            // -- Results will be filtered by the criteria in the Search Criteria box
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Revenue Reporting")]
        public void ReportingRevenue_InvalidDateSubmit_Error()
        {
            // GWT 4
            // - Given
            // -- There are not dates in the Start Date and End Date fields
            // - When
            // -- I press the Submit button
            // - Then
            // -- I will see text on the screen in red that says "Please select a date range"
            // -- - I'm open to where exactly this shows - we'll need to see how the field arrangement ends up fitting together
            // --No results will populate in the table below
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Revenue Reporting")]
        public void ReportingRevenue_ValidSubmit_SortColumns()
        {
            //GWT 5
            //- Given
            //-- There are dates in the Start Date and End Date fields
            //-- I have press the submit button
            // -When
            // -- I view the results in the results table
            // - Then
            // -- I will see the following SORTABLE columns:
            //            ---Country
            //            ---- Country will be abbreviated. SE = Sweden and NO = Norway
            //              -- - Path Name
            //               -- - Publisher
            //               -- - Sub - Publisher
            //               -- - Attempted Regs
            //                ---- Short for attempted registrations. This is the number of times users from this traffic source have tried to register for our site
            //                ---Rejected Regs
            //                ---- Short for rejected registrations. This is the number of times users from this traffic source have tried to register for our site and been rejected due to validation issues.Validation to be defined in another ticket.
            //                -- - Gross Regs
            //                ---- Short for gross registrations. This is the number of users from this traffic source that have tried to register for our site and have passed validation.This should equal Attempted Regs - Rejected Regs although it should not be calculated this way so that we have visibility into discrepancies
            //                -- - New Users
            //                ---- This is the number of users that have successfully registered to our site that are unique to our database
            //                -- - Revenue
            //                ---- This is the sum of all revenue generated from leads from this traffic source
            //                ---- Revenue will be converted to USD
            //                ---- Number will be prefixed with "$"
            //                -- - RPU
            //                ---- Short for Revenue Per User
            //                ---- Calculation is [Revenue(in USD)] / [Gross Registrations]
            //                ---- If Gross Registrations = 0, value in the column will be a hyphen
            //                ---- Number will be prefixed with "$"
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory("Revenue Reporting")]
        public void ReportingRevenue_ExportNoResults_CsvCreated()
        {

            //                GWT 6
            //                - Given
            //                -- There are no results in the results table
            //                - When
            //                -- I click the Export button
            //                - Then
            //                -- A.csv file will be exported to my desktop
            //                -- The.csv will be called "Revenue Report - [MM/DD/YYYY]"
            //                -- The file will consist of column headers only
            //                -- Columns in the export are the same and in the same order as columns in the results table
            throw new NotImplementedException();
        }
        [TestMethod]
        [TestCategory("Revenue Reporting")]
        public void ReportingRevenue_ExportResult_CsvCreated()
        {
            //                GWT 7
            //                - Given
            //                -- There are results in the results table
            //                - When
            //                -- I click the Export button
            //                - Then
            //                -- A.csv file will be exported to my desktop
            //                -- The.csv will be called "Revenue Report - [MM/DD/YYYY]"
            //                -- The file will include column headers
            //                -- Columns in the export are the same and in the same order as columns in the results table
            //                -- Results in the table exported should match the results displayed on the reporting page
            //
            throw new NotImplementedException();
        }
    }
}
