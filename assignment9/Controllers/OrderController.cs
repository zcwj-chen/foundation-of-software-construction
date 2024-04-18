using assignment9.modules;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace assignment9.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderContext orderDb;

        public OrderController(OrderContext context) { 
            this.orderDb = context;
        }

        [HttpGet("id")]
        public ActionResult<Order> getOrder(string id)
        {
            var order = orderDb.Orders.FirstOrDefault(o => o.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }

        private IQueryable<Order> buildQuery(string? cusName,DateTime? createTime)
        {
            IQueryable<Order> query = orderDb.Orders;
            if(cusName != null)
            {
                query = query.Where(o => o.CustomerName.Contains(cusName));
            }
            if(createTime != null)
            {
                query = query.Where(o => o.CreateTime == createTime);
            }
            return query;
        }

        [HttpGet]
        public ActionResult<List<Order>> getOrders(string? cusName,DateTime? createTime) { 
            var query = buildQuery(cusName,createTime);
            return query.ToList();
        }

        [HttpGet("pageQuery")]
        public ActionResult<List<Order>> queryOrder(string? cusName,DateTime? createTime,int skip,int take)
        {
            var query = buildQuery(cusName,createTime).Skip(skip).Take(take);
            return query.ToList();
        }

        [HttpPost]
        public ActionResult<Order> postOrder(Order order)
        {
            try
            {
                orderDb.Orders.Add(order);
                orderDb.SaveChanges();
            }catch (Exception ex)
            {
                string error = (ex.InnerException == null)?ex.Message:ex.InnerException.Message;
                return BadRequest(error);
            }
            return order;
        }

        [HttpPut("{id}")]
        public ActionResult<Order> putOrder(string id,Order order)
        {
            if(id != order.OrderId)
            {
                return BadRequest("Id cannot be modified");
            }
            try
            {
                orderDb.Entry(order).State = EntityState.Modified;
                orderDb.SaveChanges();
            }catch(Exception ex)
            {
                string error = (ex.InnerException == null)?ex.Message:ex.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult deleteOrder(string id)
        {
            try
            {
                var order = orderDb.Orders.FirstOrDefault(o => o.OrderId == id);
                if(order != null)
                {
                    orderDb.Remove(order);
                    orderDb.SaveChanges();
                }
            }catch (Exception ex) { 
                string error = (ex.InnerException == null)?ex.Message:ex.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }
    }
}
