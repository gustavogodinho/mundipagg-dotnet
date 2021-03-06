﻿using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using RestSharp.Easy.Models;

namespace Mundipagg.Resources.Interface
{
    /// <summary>
    /// Charge manager
    /// </summary>
    public interface IChargeResource : IResource
    {
        /// <summary>
        /// Creates a new charge2
        /// <see cref="https://docs.mundipagg.com/v1/reference#incluir-cobranca-no-pedido"/>
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, ErrorsResponse> CreateCharge(string idempotencyKey, CreateChargeRequest request);

        /// <summary>
        /// Get a charge from its id
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, ErrorsResponse> GetCharge(string chargeId);

        /// <summary>
        /// Retries a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, ErrorsResponse> RetryCharge(string chargeId);

        /// <summary>
        /// Lists all charges
        /// </summary>
        /// <return>Returns the Models.ListChargesResponse response from the API call</return>
        BaseResponse<ListChargesResponse, ErrorsResponse> ListCharges(ListChargesRequest request);

        /// <summary>
        /// Updates the metadata from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, ErrorsResponse> UpdateChargeMetadata(string chargeId, UpdateMetadataRequest request);

        /// <summary>
        /// Cancel a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for cancelling a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, ErrorsResponse> CancelCharge(string idempotencyKey, string chargeId, CreateCancelChargeRequest request = null);

        /// <summary>
        /// Captures a charge
        /// </summary>
        /// <param name="idempontencyKey">Required parameter: Idempontency Key</param>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for capturing a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, ErrorsResponse> CaptureCharge(string idempotencyKey, string chargeId, CreateCaptureChargeRequest request = null);

        /// <summary>
        /// Confirm Charge payment
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id</param>
        /// <param name="request">Optional parameter: Request for confirm payment</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, ErrorsResponse> ConfirmChargePayment(string chargeId, CreateConfirmPaymentRequest request = null);

        /// <summary>
        /// Updates the due date from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id</param>
        /// <param name="request">Required parameter: Request for updating the due date</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, ErrorsResponse> UpdateChargeDueDate(string chargeId, UpdateChargeDueDateRequest request);
       
        /// <summary>
        /// Updates the card from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating a charge's card</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, ErrorsResponse> UpdateChargeCard(string chargeId, UpdateChargeCardRequest request);

        /// <summary>
        /// Updates a charge's payment method
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating the payment method from a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, ErrorsResponse> UpdateChargePaymentMethod(string chargeId, UpdateChargePaymentMethodRequest request);
    }
}