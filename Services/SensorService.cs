using NM.APP.CORE.Domain.Entities;
using NM.APP.CORE.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM.CORE.Application.Services
{
    public class SensorService
    {
        private readonly ISensorRepository _sensorRepository;

        public SensorService(ISensorRepository sensorRepository)
        {
            _sensorRepository = sensorRepository;
        }

        // Implementation of SensorService class

        public Task<IEnumerable<Sensor>> GetAllSensorsAsync()
        {
            return _sensorRepository.GetAllAsync();
        }

        public Task<Sensor?> GetSensorByIdAsync(int sensorId)
        {
            return _sensorRepository.GetByIdAsync(sensorId);
        }

        public Task AddSensorAsync(Sensor sensor)
        {
            return _sensorRepository.AddAsync(sensor);
        }

        public Task UpdateSensorAsync(Sensor sensor)
        {
            return _sensorRepository.UpdateAsync(sensor);
        }

        public Task<Sensor> DeleteSensorAsync(int sensorId)
        {
            return _sensorRepository.DeleteAsync(sensorId);
        }
    }
}
