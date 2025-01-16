using Application.Contracts.DigitalAccount.Dto;
using Infraestructure.Repositories;
using DigitalAccountModel = Domain.Entities.DigitalAccount.DigitalAccount;

namespace Application.Contracts.DigitalAccount.Services
{
    public class DigitalAccountService
    {
        private readonly DigitalAccountRepository _digitalAccountRepository;

        public DigitalAccountService(DigitalAccountRepository digitalAccountRepository)
        {
            _digitalAccountRepository = digitalAccountRepository;
        }

        public async Task<DigitalAccountModel> Create(CreateDigitalAccountDto digitalAccountDto)
        {
            var digitalAccount = new DigitalAccountModel(Amount: digitalAccountDto.Amount);
            var data = await _digitalAccountRepository.CreateAsync(digitalAccount);
            return data;
        }

        public async Task<List<DigitalAccountModel>> GetAll()
        {
            return await _digitalAccountRepository.GetAllAsync();
        }

        public async Task<DigitalAccountModel?> GetById(Guid id)
        {
            return await _digitalAccountRepository.FindById(id);
        }

        public async Task<DigitalAccountModel?> DeleteById(Guid id)
        {
            return await _digitalAccountRepository.DeleteByIdAsync(id);
        }
    }
}
