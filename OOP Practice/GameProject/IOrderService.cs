using System;

namespace GameProject;

public interface IOrderService
{
    void PlaceOrder(Campaign campaign, Gamer gamer);
    
}
