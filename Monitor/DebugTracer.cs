using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using IBLeier.VictronEnergy.Monitor;
using Microsoft.Rest;

namespace Monitor
{
    internal class DebugTracer : IServiceClientTracingInterceptor
    {
        public void Information(string message)
        {
            Debug.WriteLine(message);
            Logging.Log("Information", message);
        }

        public void TraceError(string invocationId, Exception exception)
        {
            Debug.WriteLine("Exception in {0}: {1}", invocationId, exception);
            string message = string.Format("Exception in {0}: {1}", invocationId, exception);
            Logging.Log("TraceError", message);
        }

        public void ReceiveResponse(string invocationId, HttpResponseMessage response)
        {
            string requestAsString = (response == null ? string.Empty : response.AsFormattedString());
            Debug.WriteLine("invocationId: {0}\r\nresponse: {1}", invocationId, requestAsString);
            string message = string.Format("invocationId: {0}\r\nresponse: {1}", invocationId, requestAsString);
            Logging.Log("ReceiveResponse", message);
        }

        public void SendRequest(string invocationId, HttpRequestMessage request)
        {
            string requestAsString = (request == null ? string.Empty : request.AsFormattedString());
            Debug.WriteLine("invocationId: {0}\r\nrequest: {1}", invocationId, requestAsString);
            string message = string.Format("invocationId: {0}\r\nrequest: {1}", invocationId, requestAsString);
            Logging.Log("SendRequest", message);
        }

        public void Configuration(string source, string name, string value)
        {
            Debug.WriteLine("Configuration: source={0}, name={1}, value={2}", source, name, value);
            string message = string.Format("Configuration: source={0}, name={1}, value={2}", source, name, value);
            Logging.Log("Configuration", message);
        }

        public void EnterMethod(string invocationId, object instance, string method, IDictionary<string, object> parameters)
        {
            Debug.WriteLine("invocationId: {0}\r\ninstance: {1}\r\nmethod: {2}\r\nparameters: {3}",
                invocationId, instance, method, parameters.AsFormattedString());
            string message = string.Format("invocationId: {0}\r\ninstance: {1}\r\nmethod: {2}\r\nparameters: {3}",
                invocationId, instance, method, parameters.AsFormattedString());
            Logging.Log("EnterMethod", message);
        }

        public void ExitMethod(string invocationId, object returnValue)
        {
            string returnValueAsString = (returnValue == null ? string.Empty : returnValue.ToString());
            Debug.WriteLine("Exit with invocation id {0}, the return value is {1}",
                invocationId, returnValueAsString);
            string message = string.Format("Exit with invocation id {0}, the return value is {1}",
                invocationId, returnValueAsString);
            Logging.Log("EnterMethod", message);
        }
    }
}
