using Banking.Operation.Transfer.Query.Domain.Tranfers.Dtos;
using System;

namespace Banking.Operation.Transfer.Query.Domain.Tranfers.Entities
{
    public class TransferEntity : TEntityBase
    {
        public Guid ReceiptId { get; set; }
        public Guid ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientEmail { get; set; }
        public Guid ContactId { get; set; }
        public string ContactName { get; set; }
        public decimal Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public TransferDto ToDto()
        {
            var transferDto = new TransferDto();
            transferDto.ReceiptId = this.ReceiptId;
            transferDto.ClientId = this.ClientId;
            transferDto.ClientName = this.ClientName;
            transferDto.ClientEmail = this.ClientEmail;
            transferDto.ContactId = this.ContactId;
            transferDto.ContactName = this.ContactName;
            transferDto.Value = this.Value;
            transferDto.CreatedAt = this.CreatedAt;
            transferDto.CreatedBy = this.CreatedBy;
            return transferDto;
        }
    }
}