using System.Threading.Tasks;
using Twilio.Clients;
using Twilio.Deleters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Resources.Api.V2010.Account.Message;

namespace Twilio.Deleters.Api.V2010.Account.Message {

    public class MediaDeleter : Deleter<MediaResource> {
        private string accountSid;
        private string messageSid;
        private string sid;
    
        /**
         * Construct a new MediaDeleter
         * 
         * @param accountSid The account_sid
         * @param messageSid The message_sid
         * @param sid Delete by unique media Sid
         */
        public MediaDeleter(string accountSid, string messageSid, string sid) {
            this.accountSid = accountSid;
            this.messageSid = messageSid;
            this.sid = sid;
        }
    
        /**
         * Make the request to the Twilio API to perform the delete
         * 
         * @param client ITwilioRestClient with which to make the request
         */
        public override async Task ExecuteAsync(ITwilioRestClient client) {
            Request request = new Request(
                System.Net.Http.HttpMethod.Delete,
                Domains.API,
                "/2010-04-01/Accounts/" + this.accountSid + "/Messages/" + this.messageSid + "/Media/" + this.sid + ".json"
            );
            
            Response response = await client.Request(request);
            
            if (response == null) {
                throw new ApiConnectionException("MediaResource delete failed: Unable to connect to server");
            } else if (response.GetStatusCode() != HttpStatus.HTTP_STATUS_CODE_NO_CONTENT) {
                RestException restException = RestException.FromJson(response.GetContent());
                if (restException == null)
                    throw new ApiException("Server Error, no content");
                throw new ApiException(
                    restException.GetMessage(),
                    restException.GetCode(),
                    restException.GetMoreInfo(),
                    restException.GetStatus(),
                    null
                );
            }
            
            return;
        }
    }
}