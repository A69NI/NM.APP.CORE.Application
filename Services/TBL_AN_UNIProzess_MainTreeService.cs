using NM.CORE.Domain.Entities;
using NM.CORE.Domain.Repositories;

namespace NM.CORE.Application.Services
{
    public class TBL_AN_UNIProzess_MainTreeService
    {
        private readonly ITBL_AN_UNIProzesse_MainTreeRepository _tBL_AN_UNIProzesse_MainTreeRepository;

        public TBL_AN_UNIProzess_MainTreeService(ITBL_AN_UNIProzesse_MainTreeRepository tBL_AN_UNIProzesse_MainTreeRepository)
        {
            _tBL_AN_UNIProzesse_MainTreeRepository = tBL_AN_UNIProzesse_MainTreeRepository;
        }

        // Implementation of SensorService class

        public Task<IEnumerable<TBL_AN_UNIProzesse_MainTree>> GetAllAsync()
        {
            return _tBL_AN_UNIProzesse_MainTreeRepository.GetAllAsync();
        }

        public Task<TBL_AN_UNIProzesse_MainTree?> GetByIdAsync(int sensorId)
        {
            return _tBL_AN_UNIProzesse_MainTreeRepository.GetByIdAsync(sensorId);
        }

        public Task AddAsync(TBL_AN_UNIProzesse_MainTree tBL_AN_UNIProzesse_MainTree)
        {
            return _tBL_AN_UNIProzesse_MainTreeRepository.AddAsync(tBL_AN_UNIProzesse_MainTree);
        }

        public Task UpdateAsync(TBL_AN_UNIProzesse_MainTree tBL_AN_UNIProzesse_MainTree)
        {
            return _tBL_AN_UNIProzesse_MainTreeRepository.UpdateAsync(tBL_AN_UNIProzesse_MainTree);
        }

        public Task<TBL_AN_UNIProzesse_MainTree> DeleteAsync(int Id)
        {
            return _tBL_AN_UNIProzesse_MainTreeRepository.DeleteAsync(Id);
        }
    }
}
