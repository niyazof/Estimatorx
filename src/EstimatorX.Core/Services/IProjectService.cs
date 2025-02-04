using System.Security.Principal;

using EstimatorX.Shared.Models;

namespace EstimatorX.Core.Services;

public interface IProjectService
{
    Task Delete(string id, string partitionKey, IPrincipal principal, CancellationToken cancellationToken);

    Task<Project> Load(string id, string partitionKey, IPrincipal principal, CancellationToken cancellationToken);

    Task<Project> Save(string id, string partitionKey, Project model, IPrincipal principal, CancellationToken cancellationToken);

    Task<Project> Create(Project model, IPrincipal principal, CancellationToken cancellationToken);

    Task<QueryResult<TResult>> Search<TResult>(QueryRequest queryModel, IPrincipal principal, CancellationToken cancellationToken);
}
