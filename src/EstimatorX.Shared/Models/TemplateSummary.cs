﻿using EstimatorX.Shared.Definitions;

namespace EstimatorX.Shared.Models;

public class TemplateSummary : ModelBase, IHaveOrganization
{
    public string Name { get; set; }

    public string Description { get; set; }

    public string OrganizationId { get; set; }

    public string OrganizationName { get; set; }
}
