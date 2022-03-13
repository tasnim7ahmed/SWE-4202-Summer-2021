using System;

namespace LINQBasics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Restriction Operators
            RestrictionOp restrictionop = new RestrictionOp();
            //restrictionop.filteringOnProperty();

            //Projection Operators
            ProjectionOp projectionop = new ProjectionOp();
            //projectionop.projectionFromMultipleInputs();

            //Partition Operators
            PartitionOp partitionOp = new PartitionOp();
            //partitionOp.takeWhileAndSkipWhile();

            //Ordering Operators
            OrderingOp orderingop = new OrderingOp();
            orderingop.orderingByMultipleFields();

        }
    }
}
