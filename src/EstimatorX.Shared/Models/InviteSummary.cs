﻿
using EstimatorX.Shared.Definitions;

namespace EstimatorX.Shared.Models;

public class InviteSummary : ModelBase, IHaveOrganization, IHaveName
{
    public string Name { get; set; }

    public string Email { get; set; }

    public string OrganizationId { get; set; }

    public string OrganizationName { get; set; }

}
