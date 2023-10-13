﻿using Skoruba.IdentityServer4.Admin.EntityFramework.Helpers;
using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityServer.Skoruba.Admin.Admin.Api.Dtos.Clients
{
    public class ClientSecretApiDto
    {
        [Required]
        public string Type { get; set; } = "SharedSecret";

        public int Id { get; set; }

        public string Description { get; set; }

        [Required]
        public string Value { get; set; }

        public string HashTypeStr { get; set; }

        public HashType HashTypeEnum => Enum.TryParse(HashTypeStr, true, out HashType result) ? result : HashType.Sha256;

        public DateTime? Expiration { get; set; }
    }
}






