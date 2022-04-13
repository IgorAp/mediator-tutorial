using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTutorial.Core.Messages
{
    public abstract class Command : Message, IRequest<bool>
    {

    }
}
