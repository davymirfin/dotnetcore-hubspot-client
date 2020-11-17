﻿using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using RapidCore.Network;
using Skarp.HubSpotClient.Core;

namespace Skarp.HubSpotClient.FunctionalTests.Mocks.Contact
{
    public class GetContactByEmailMockTestCase : IMockRapidHttpClientTestCase
    {
        public bool IsMatch(HttpRequestMessage request)
        {
            return request.RequestUri.AbsolutePath.Contains("/contacts/v1/contact/email/testingapis@hubspot.com") 
                && request.RequestUri.Query.Contains("property=my_custom_property")
                && request.RequestUri.Query.Contains("property=hs_object_id")
                && request.RequestUri.Query.Contains("propertyMode=value_only")
                && request.RequestUri.Query.Contains("formSubmissionMode=newest")
                && request.RequestUri.Query.Contains("showListMemberships=false")
                && request.Method == HttpMethod.Get;
        }

        public Task<HttpResponseMessage> GetResponseAsync(HttpRequestMessage request)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);

            const string jsonResponse =
                "{\"vid\":3234574,\"canonical-vid\":3234574,\"merged-vids\":[],\"portal-id\":62515,\"is-contact\":true,\"profile-token\":\"AO_T-mMHif7QAFic7V-i9wENd87kiVQRW2bvfE_7z9lsOleT8XyJXlVAww3VCT2JzE2zMwTBtf_fNYnJAtL00lE6bXEtAN-aP0yPI_vLjWF2DfY2kcOuLVZyZk59xF1OSRhsAdO3-_yI\",\"profile-url\":\"https://app.hubspot.com/contacts/62515/lists/public/contact/_AO_T-mMHif7QAFic7V-i9wENd87kiVQRW2bvfE_7z9lsOleT8XyJXlVAww3VCT2JzE2zMwTBtf_fNYnJAtL00lE6bXEtAN-aP0yPI_vLjWF2DfY2kcOuLVZyZk59xF1OSRhsAdO3-_yI/\",\"properties\":{\"hs_analytics_last_url\":{\"value\":\"\",\"versions\":[{\"value\":\"\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"lead_source\":{\"value\":\"DiscoverOrg\",\"versions\":[{\"value\":\"DiscoverOrg\",\"source-type\":\"API\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484026593060,\"selected\":false}]},\"num_unique_conversion_events\":{\"value\":\"0\",\"versions\":[{\"value\":\"0\",\"source-type\":\"CALCULATED\",\"source-id\":null,\"source-label\":null,\"timestamp\":0,\"selected\":false}]},\"hs_analytics_revenue\":{\"value\":\"0.0\",\"versions\":[{\"value\":\"0.0\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"createdate\":{\"value\":\"1484026585538\",\"versions\":[{\"value\":\"1484026585538\",\"source-type\":\"API\",\"source-id\":\"Contacts\",\"source-label\":null,\"timestamp\":1484026585538,\"selected\":false}]},\"hs_analytics_first_referrer\":{\"value\":\"\",\"versions\":[{\"value\":\"\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"hs_email_optout\":{\"value\":\"true\",\"versions\":[{\"value\":\"true\",\"source-type\":\"EMAIL\",\"source-id\":\"Updated in response to an email address change.\",\"source-label\":null,\"timestamp\":1484026585658,\"selected\":false}]},\"hs_predictivecontactscore\":{\"value\":\"50\",\"versions\":[{\"value\":\"50\",\"source-type\":\"TASK\",\"source-id\":\"predictive-contact-scoring\",\"source-label\":\"3\",\"timestamp\":1484026586421,\"selected\":false}]},\"annualrevenue\":{\"value\":\"181900000\",\"versions\":[{\"value\":\"181900000\",\"source-type\":\"API\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484026593060,\"selected\":false}]},\"hs_analytics_num_page_views\":{\"value\":\"0\",\"versions\":[{\"value\":\"0\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"state\":{\"value\":\"MA\",\"versions\":[{\"value\":\"MA\",\"source-type\":\"API\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484026585536,\"selected\":false}]},\"zip\":{\"value\":\"02139\",\"versions\":[{\"value\":\"02139\",\"source-type\":\"API\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484026585536,\"selected\":false}]},\"fortune_rank\":{\"value\":\"\",\"versions\":[{\"value\":\"\",\"source-type\":\"API\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484026593060,\"selected\":false}]},\"hs_predictivecontactscorebucket\":{\"value\":\"bucket_3\",\"versions\":[{\"value\":\"bucket_3\",\"source-type\":\"TASK\",\"source-id\":\"predictive-contact-scoring\",\"source-label\":\"3\",\"timestamp\":1484857784401,\"selected\":false},{\"value\":\"bucket_2\",\"source-type\":\"TASK\",\"source-id\":\"predictive-contact-scoring\",\"source-label\":\"3\",\"timestamp\":1484026587692,\"selected\":false},{\"value\":\"bucket_3\",\"source-type\":\"TASK\",\"source-id\":\"predictive-contact-scoring\",\"source-label\":\"3\",\"timestamp\":1484026586421,\"selected\":false}]},\"hubspotscore\":{\"value\":\"0\",\"versions\":[{\"value\":\"0\",\"source-type\":\"WAL_INCREMENTAL\",\"source-id\":\"csrsu-kafka\",\"source-label\":null,\"timestamp\":1484026586290,\"selected\":false}]},\"linkedinconnections\":{\"value\":\"0\",\"versions\":[{\"value\":\"0\",\"source-type\":\"WAL_INCREMENTAL\",\"source-id\":\"iwsmp\",\"source-label\":null,\"timestamp\":1484026586434,\"selected\":false}]},\"hs_lifecyclestage_subscriber_date\":{\"value\":\"1484026585538\",\"versions\":[{\"value\":\"1484026585538\",\"source-type\":\"API\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484026585538,\"selected\":false}]},\"hs_analytics_average_page_views\":{\"value\":\"0\",\"versions\":[{\"value\":\"0\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"lastname\":{\"value\":\"Huang\",\"versions\":[{\"value\":\"Huang\",\"source-type\":\"BATCH_UPDATE\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484858430193,\"selected\":false},{\"value\":\"Test\",\"source-type\":\"API\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484857783087,\"selected\":false},{\"value\":\"Mott\",\"source-type\":\"API\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484026585536,\"selected\":false}]},\"twitterhandle\":{\"value\":\"ghidinelli\",\"versions\":[{\"value\":\"ghidinelli\",\"source-type\":\"WAL_INCREMENTAL\",\"source-id\":\"iwsmp\",\"source-label\":null,\"timestamp\":1484026586434,\"selected\":false}]},\"phone\":{\"value\":\"555-122-2323\",\"versions\":[{\"value\":\"555-122-2323\",\"source-type\":\"API\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484026585536,\"selected\":false}]},\"num_conversion_events\":{\"value\":\"0\",\"versions\":[{\"value\":\"0\",\"source-type\":\"CALCULATED\",\"source-id\":null,\"source-label\":null,\"timestamp\":0,\"selected\":false}]},\"currentlyinworkflow\":{\"value\":\"false\",\"versions\":[{\"value\":\"false\",\"source-type\":\"WORKFLOWS\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484026663404,\"selected\":false},{\"value\":\"true\",\"source-type\":\"WORKFLOWS\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484026588355,\"selected\":false}]},\"hs_analytics_num_event_completions\":{\"value\":\"2\",\"versions\":[{\"value\":\"2\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484653296522,\"selected\":false},{\"value\":\"1\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484049018265,\"selected\":false},{\"value\":\"0\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"followercount\":{\"value\":\"582\",\"versions\":[{\"value\":\"582\",\"source-type\":\"WAL_INCREMENTAL\",\"source-id\":\"iwsmp\",\"source-label\":null,\"timestamp\":1484026586434,\"selected\":false}]},\"hs_email_optout_2849\":{\"value\":\"\",\"versions\":[{\"value\":\"\",\"source-type\":\"EMAIL\",\"source-id\":\"Updated in response to an email address change.\",\"source-label\":null,\"timestamp\":1484026585658,\"selected\":false}]},\"associatedcompanyid\":{\"value\":\"184896670\",\"versions\":[{\"value\":\"184896670\",\"source-type\":\"COMPANIES\",\"source-id\":\"WriteAssociatedCompanyIdStep\",\"source-label\":null,\"timestamp\":1484026585846,\"selected\":false}]},\"firstname\":{\"value\":\"Codey\",\"versions\":[{\"value\":\"Codey\",\"source-type\":\"BATCH_UPDATE\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484858430193,\"selected\":false},{\"value\":\"HubSpot\",\"source-type\":\"API\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484857783087,\"selected\":false},{\"value\":\"Adrian\",\"source-type\":\"API\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484026585536,\"selected\":false}]},\"city\":{\"value\":\"Cambridge\",\"versions\":[{\"value\":\"Cambridge\",\"source-type\":\"API\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484026585536,\"selected\":false}]},\"hs_email_optout_354586\":{\"value\":\"\",\"versions\":[{\"value\":\"\",\"source-type\":\"EMAIL\",\"source-id\":\"Updated in response to an email address change.\",\"source-label\":null,\"timestamp\":1484026585658,\"selected\":false}]},\"hs_social_num_broadcast_clicks\":{\"value\":\"0\",\"versions\":[{\"value\":\"0\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"hs_analytics_last_timestamp\":{\"value\":\"\",\"versions\":[{\"value\":\"\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"hs_analytics_num_visits\":{\"value\":\"0\",\"versions\":[{\"value\":\"0\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"twitterbio\":{\"value\":\"Racer, entrepreneur, world traveler. Crossfitter, foodie, kitesurfing newbie. If racing is life, I\'m building a lifestyle business @MotorsportReg @RaceHeroApp\",\"versions\":[{\"value\":\"Racer, entrepreneur, world traveler. Crossfitter, foodie, kitesurfing newbie. If racing is life, I\'m building a lifestyle business @MotorsportReg @RaceHeroApp\",\"source-type\":\"WAL_INCREMENTAL\",\"source-id\":\"iwsmp\",\"source-label\":null,\"timestamp\":1484026586434,\"selected\":false}]},\"hs_social_linkedin_clicks\":{\"value\":\"0\",\"versions\":[{\"value\":\"0\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"hs_analytics_last_visit_timestamp\":{\"value\":\"\",\"versions\":[{\"value\":\"\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"hs_social_last_engagement\":{\"value\":\"\",\"versions\":[{\"value\":\"\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"hs_twitterid\":{\"value\":\"49019793\",\"versions\":[{\"value\":\"49019793\",\"source-type\":\"WAL_INCREMENTAL\",\"source-id\":\"iwsmp\",\"source-label\":null,\"timestamp\":1484026586434,\"selected\":false}]},\"associatedcompanylastupdated\":{\"value\":\"13365279006997343\",\"versions\":[{\"value\":\"13365279006997343\",\"source-type\":\"COMPANIES\",\"source-id\":\"WriteAssociatedCompanyIdStep\",\"source-label\":null,\"timestamp\":1484026585846,\"selected\":false}]},\"hs_analytics_source\":{\"value\":\"OFFLINE\",\"versions\":[{\"value\":\"OFFLINE\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"company\":{\"value\":\"HubSpot\",\"versions\":[{\"value\":\"HubSpot\",\"source-type\":\"API\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484026585536,\"selected\":false}]},\"email\":{\"value\":\"testingapis@hubspot.com\",\"versions\":[{\"value\":\"testingapis@hubspot.com\",\"source-type\":\"API\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484026585536,\"selected\":false}]},\"linkedinbio\":{\"value\":\"Racecar driver, entrepreneur, world traveler\",\"versions\":[{\"value\":\"Racecar driver, entrepreneur, world traveler\",\"source-type\":\"WAL_INCREMENTAL\",\"source-id\":\"iwsmp\",\"source-label\":null,\"timestamp\":1484026586434,\"selected\":false}]},\"hs_analytics_first_url\":{\"value\":\"\",\"versions\":[{\"value\":\"\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"website\":{\"value\":\"http://hubspot.com\",\"versions\":[{\"value\":\"http://hubspot.com\",\"source-type\":\"API\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484857783087,\"selected\":false},{\"value\":\"http://www.hubspot.com\",\"source-type\":\"API\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484026663212,\"selected\":false},{\"value\":\"http://hubspot.com\",\"source-type\":\"API\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484026585536,\"selected\":false}]},\"address\":{\"value\":\"25 First Street\",\"versions\":[{\"value\":\"25 First Street\",\"source-type\":\"API\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484026585536,\"selected\":false}]},\"hs_analytics_first_visit_timestamp\":{\"value\":\"\",\"versions\":[{\"value\":\"\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"hs_analytics_first_timestamp\":{\"value\":\"1484026585538\",\"versions\":[{\"value\":\"1484026585538\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"lastmodifieddate\":{\"value\":\"1484858431084\",\"versions\":[{\"value\":\"1484858431084\",\"source-type\":\"CALCULATED\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484858431084,\"selected\":false}]},\"photo\":{\"value\":\"https://d2ojpxxtu63wzl.cloudfront.net/static/5b37fd1365186dd697c8a4c950be4222_f4b374414287ef87185ce792c90c266ce333e83eac137c3105bdbd20994556a5\",\"versions\":[{\"value\":\"https://d2ojpxxtu63wzl.cloudfront.net/static/5b37fd1365186dd697c8a4c950be4222_f4b374414287ef87185ce792c90c266ce333e83eac137c3105bdbd20994556a5\",\"source-type\":\"WAL_INCREMENTAL\",\"source-id\":\"iwsmp\",\"source-label\":null,\"timestamp\":1484026586434,\"selected\":false}]},\"hs_social_google_plus_clicks\":{\"value\":\"0\",\"versions\":[{\"value\":\"0\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"hs_analytics_last_referrer\":{\"value\":\"\",\"versions\":[{\"value\":\"\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"kloutscoregeneral\":{\"value\":\"48\",\"versions\":[{\"value\":\"48\",\"source-type\":\"WAL_INCREMENTAL\",\"source-id\":\"iwsmp\",\"source-label\":null,\"timestamp\":1484026586434,\"selected\":false}]},\"hs_email_optout_230318\":{\"value\":\"\",\"versions\":[{\"value\":\"\",\"source-type\":\"EMAIL\",\"source-id\":\"Updated in response to an email address change.\",\"source-label\":null,\"timestamp\":1484026585658,\"selected\":false}]},\"hs_social_facebook_clicks\":{\"value\":\"0\",\"versions\":[{\"value\":\"0\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"twitterprofilephoto\":{\"value\":\"https://pbs.twimg.com/profile_images/712369625632116736/PNku5AjB_reasonably_small.jpg\",\"versions\":[{\"value\":\"https://pbs.twimg.com/profile_images/712369625632116736/PNku5AjB_reasonably_small.jpg\",\"source-type\":\"WAL_INCREMENTAL\",\"source-id\":\"iwsmp\",\"source-label\":null,\"timestamp\":1484026586434,\"selected\":false}]},\"hs_analytics_source_data_2\":{\"value\":\"\",\"versions\":[{\"value\":\"\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"hs_social_twitter_clicks\":{\"value\":\"0\",\"versions\":[{\"value\":\"0\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"hs_analytics_source_data_1\":{\"value\":\"API\",\"versions\":[{\"value\":\"API\",\"source-type\":\"ANALYTICS\",\"source-id\":\"ContactAnalyticsDetailsUpdateWorker\",\"source-label\":null,\"timestamp\":1484026587400,\"selected\":false}]},\"lifecyclestage\":{\"value\":\"subscriber\",\"versions\":[{\"value\":\"subscriber\",\"source-type\":\"API\",\"source-id\":null,\"source-label\":null,\"timestamp\":1484026585538,\"selected\":false}]}},\"form-submissions\":[],\"list-memberships\":[{\"static-list-id\":1,\"internal-list-id\":220441,\"timestamp\":1484026586509,\"vid\":3234574,\"is-member\":true},{\"static-list-id\":230006,\"internal-list-id\":230635,\"timestamp\":1484026588372,\"vid\":3234574,\"is-member\":true},{\"static-list-id\":230008,\"internal-list-id\":230637,\"timestamp\":1484026663355,\"vid\":3234574,\"is-member\":true},{\"static-list-id\":232135,\"internal-list-id\":232770,\"timestamp\":1484026586509,\"vid\":3234574,\"is-member\":true},{\"static-list-id\":236675,\"internal-list-id\":237312,\"timestamp\":1484026588449,\"vid\":3234574,\"is-member\":true},{\"static-list-id\":236677,\"internal-list-id\":237314,\"timestamp\":1484026593326,\"vid\":3234574,\"is-member\":true},{\"static-list-id\":236813,\"internal-list-id\":237460,\"timestamp\":1484026586509,\"vid\":3234574,\"is-member\":true}],\"identity-profiles\":[{\"vid\":3234574,\"saved-at-timestamp\":1484026585613,\"deleted-changed-timestamp\":0,\"identities\":[{\"type\":\"EMAIL\",\"value\":\"testingapis@hubspot.com\",\"timestamp\":1484026585538},{\"type\":\"LEAD_GUID\",\"value\":\"4b11f8af-50d9-4665-9c43-bb2fc46e3a80\",\"timestamp\":1484026585610}]}],\"merge-audits\":[],\"associated-company\":{\"company-id\":184896670,\"portal-id\":62515,\"properties\":{\"country\":{\"value\":\"United States\"},\"city\":{\"value\":\"Cambridge\"},\"num_associated_contacts\":{\"value\":\"102\"},\"timezone\":{\"value\":\"America/New_York\"},\"facebook_company_page\":{\"value\":\"https://www.facebook.com/hubspot\"},\"createdate\":{\"value\":\"1457708103847\"},\"description\":{\"value\":\"HubSpot is the world’s leading inbound marketing and sales platform. Since 2006, HubSpot has been on a mission to make the world more inbound. Today, over 10,000 customers in 65 countries use HubSpot’s software, services, and support to transform the way they attract, engage, and delight customers. HubSpot’s inbound marketing software, ranked #1 in customer satisfaction by VentureBeat and G2Crowd, includes social media publishing and monitoring, blogging, SEO, website content management, email marketing, marketing automation, and reporting and analytics, all in one integrated platform. Signals, HubSpot’s award-winning sales application, enables sales and service teams to have more effective conversations with leads, prospects, and customers. HubSpot is headquartered in Cambridge, MA with an office in Dublin, Ireland, and has been recognized by Inc., Forbes, and Deloitte as one of the world’s fastest-growing companies.\"},\"industry\":{\"value\":\"COMPUTER_SOFTWARE\"},\"total_money_raised\":{\"value\":\"$100.5M\"},\"days_to_close\":{\"value\":\"220\"},\"hs_analytics_num_visits\":{\"value\":\"0\"},\"linkedin_company_page\":{\"value\":\"http://www.linkedin.com/company/68529\"},\"recent_conversion_event_name\":{\"value\":\"Contact Us: excedalogic form\"},\"hs_analytics_source\":{\"value\":\"OFFLINE\"},\"num_contacted_notes\":{\"value\":\"12\"},\"annualrevenue\":{\"value\":\"250000000\"},\"founded_year\":{\"value\":\"2006\"},\"hs_analytics_num_page_views\":{\"value\":\"0\"},\"state\":{\"value\":\"MA\"},\"linkedinbio\":{\"value\":\"HubSpot is the world’s leading inbound marketing and sales platform. Since 2006, HubSpot has been on a mission to make the world more inbound. Today, over 10,000 customers in 65 countries use HubSpot’s software, services, and support to transform the way they attract, engage, and delight customers. HubSpot’s inbound marketing software, ranked #1 in customer satisfaction by VentureBeat and G2Crowd, includes social media publishing and monitoring, blogging, SEO, website content management, email marketing, marketing automation, and reporting and analytics, all in one integrated platform. Signals, HubSpot’s award-winning sales application, enables sales and service teams to have more effective conversations with leads, prospects, and customers. HubSpot is headquartered in Cambridge, MA with an office in Dublin, Ireland, and has been recognized by Inc., Forbes, and Deloitte as one of the world’s fastest-growing companies.\"},\"notes_next_activity_date\":{\"value\":\"\"},\"zip\":{\"value\":\"02141\"},\"notes_last_updated\":{\"value\":\"1480625888696\"},\"website\":{\"value\":\"hubspot.com\"},\"closedate\":{\"value\":\"1476768116137\"},\"hs_analytics_first_timestamp\":{\"value\":\"1390574181854\"},\"first_conversion_date\":{\"value\":\"1477892839033\"},\"engagements_last_meeting_booked\":{\"value\":\"\"},\"first_contact_createdate\":{\"value\":\"1390574181854\"},\"twitterhandle\":{\"value\":\"HubSpot\"},\"hs_lastmodifieddate\":{\"value\":\"1484854497180\"},\"notes_last_contacted\":{\"value\":\"1479030015191\"},\"phone\":{\"value\":\"+1 888-482-7768\"},\"num_conversion_events\":{\"value\":\"40\"},\"domain\":{\"value\":\"hubspot.com\"},\"is_public\":{\"value\":\"true\"},\"name\":{\"value\":\"Hubspot, Inc.\"},\"recent_conversion_date\":{\"value\":\"1484844458500\"},\"hs_analytics_source_data_2\":{\"value\":\"\"},\"hs_analytics_source_data_1\":{\"value\":\"\"},\"first_conversion_event_name\":{\"value\":\"excedalogic form\"},\"num_notes\":{\"value\":\"12\"}}}}";
            
            response.Content = new JsonContent(jsonResponse);
            response.RequestMessage = request;

            return Task.FromResult(response);
        }
    }
}