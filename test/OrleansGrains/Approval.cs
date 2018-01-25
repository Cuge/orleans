using Orleans;
using OrleansGrainInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrleansGrains
{
    public class Approval<T> : Grain, OrleansGrainInterfaces.IApproval<T>
    {
        public async Task<bool> Approve(T proposal)
        {
            Console.WriteLine(proposal.ToString());
            return await Task.FromResult(true);
        }

        public async Task<bool> Reject(T proposal)
        {
            Console.WriteLine($"Reject: {proposal.ToString()}");
            return await Task.FromResult(false);
        }
    }

    public class ApprovalInt : Approval<int>, OrleansGrainInterfaces.IApproval<int>
    {
    }

    public class User : IUser
    {
        public async Task<string> Approve(string str)
        {
            return await Task.FromResult("Weihua Approved.");
        }

        public async Task<string> GetName()
        {
            return await Task.FromResult("Weihua.");
        }
    }
}
