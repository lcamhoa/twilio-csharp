using Twilio.Base;
using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Taskrouter.V1.Workspace.Task 
{

    public class ReservationFetcher : Fetcher<ReservationResource> 
    {
        public string WorkspaceSid { get; }
        public string TaskSid { get; }
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new ReservationFetcher
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="taskSid"> The task_sid </param>
        /// <param name="sid"> The sid </param>
        public ReservationFetcher(string workspaceSid, string taskSid, string sid)
        {
            WorkspaceSid = workspaceSid;
            TaskSid = taskSid;
            Sid = sid;
        }
    
        #if NET40
        /// <summary>
        /// Make the request to the Twilio API to perform the fetch
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Fetched ReservationResource </returns> 
        public override async System.Threading.Tasks.Task<ReservationResource> FetchAsync(ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.GET,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + WorkspaceSid + "/Tasks/" + TaskSid + "/Reservations/" + Sid + ""
            );
            
            var response = await client.RequestAsync(request);
            if (response == null)
            {
                throw new ApiConnectionException("ReservationResource fetch failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to fetch record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return ReservationResource.FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Make the request to the Twilio API to perform the fetch
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Fetched ReservationResource </returns> 
        public override ReservationResource Fetch(ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.GET,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + WorkspaceSid + "/Tasks/" + TaskSid + "/Reservations/" + Sid + ""
            );
            
            var response = client.Request(request);
            if (response == null)
            {
                throw new ApiConnectionException("ReservationResource fetch failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to fetch record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return ReservationResource.FromJson(response.Content);
        }
    }
}