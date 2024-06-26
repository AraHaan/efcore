// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.EntityFrameworkCore.TestModels.ManyToManyModel;

#nullable disable

public class EntityTableSharing2
{
    public virtual int Id { get; set; }
    public virtual long Cucumber { get; set; }
    public virtual ICollection<EntityTableSharing1> TableSharing1Shared { get; set; }
}
