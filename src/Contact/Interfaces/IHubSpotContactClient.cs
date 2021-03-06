using Skarp.HubSpotClient.Core.Interfaces;
using System.Threading.Tasks;

namespace Skarp.HubSpotClient.Contact.Interfaces
{
    public interface IHubSpotContactClient
    {
        /// <summary>
        /// Creates the contact entity asynchronously.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        Task<T> CreateAsync<T>(IContactHubSpotEntity entity) where T : IHubSpotEntity, new();
        /// <summary>
        /// Creates or updates the contact entity asynchronously.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        Task<T> CreateOrUpdateAsync<T>(IContactHubSpotEntity entity) where T : IHubSpotEntity, new();
        /// <summary>
        /// Delete an existing contact in hubspot by id
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns></returns>
        Task DeleteAsync(long contactId);
        /// <summary>
        /// Get a contact by email address
        /// </summary>
        /// <param name="email"></param>
        /// <param name="opts">Options for enabling/disabling history and specifying properties</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<T> GetByEmailAsync<T>(string email, ContactGetRequestOptions opts = null) where T : IHubSpotEntity, new();
        /// <summary>
        /// Return a single contact by id from hubspot
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="opts">Options for enabling/disabling history and specifying properties</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<T> GetByIdAsync<T>(long contactId, ContactGetRequestOptions opts = null) where T : IHubSpotEntity, new();
        /// <summary>
        /// List contacts 
        /// </summary>
        /// <param name="opts">Request options - use for pagination</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<T> ListAsync<T>(ContactListRequestOptions opts = null) where T : IHubSpotEntity, new();
        /// <summary>
        /// Update an existing contact in hubspot
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        Task UpdateAsync(IContactHubSpotEntity contact);
    }
}