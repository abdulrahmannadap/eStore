using System.Linq.Expressions;

namespace eStore.Application.common.Interfaces
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Retrieves all entities of type T, optionally filtered by a predicate and with optional included properties.
        /// </summary>
        /// <param name="filter">An optional expression to filter the entities.</param>
        /// <param name="includeProperites">An optional string specifying related properties to include.</param>
        /// <returns>A collection of entities of type T.</returns>
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperites = null);

        /// <summary>
        /// Retrieves a single entity of type T that matches the provided filter, with optional related properties included.
        /// </summary>
        /// <param name="filter">An expression to filter the entity to retrieve.</param>
        /// <param name="includeProperties">An optional string specifying related properties to include.</param>
        /// <returns>The entity of type T that matches the filter.</returns>
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null);

        /// <summary>
        /// Adds a new entity of type T to the data store.
        /// </summary>
        /// <param name="T">The entity to add.</param>
        void Add(T T);

        /// <summary>
        /// Removes an existing entity of type T from the data store.
        /// </summary>
        /// <param name="T">The entity to remove.</param>
        void Remove(T T);

    }
}
