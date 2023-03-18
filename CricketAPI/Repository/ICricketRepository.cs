using System;
using Microsoft.AspNetCore;
using CricketAPI.Entity;

namespace CricketAPI.Repository
{
    public interface ICricketRepository
    {
        public Task<IEnumerable<Cricket>> GetCricketPlayerNames();

    }
}
