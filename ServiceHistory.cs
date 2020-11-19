using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
	public class ServiceHistory
	{
		public ServiceHistory()
		{
			public LinkedList<Record> listOfServiceEngine;
		public LinkedList<Record> listOfServiceTransmission;
		public LinkedList<Record> listOfServiceTire;
		public ServiceHistory(){
			listOfServiceEngine = new LinkedList<Record>();
			listOfServiceTransmission = new LinkedList<Record>();
			listOfServiceTire = new LinkedList<Record>();
		}
		public void addlistOfServiceEngine(Record newRecord) {
			listOfServiceEngine.AddLast(newRecord);
		}
		public void addlistOfServiceTransmission(Record newRecord) {
			listOfServiceTransmission.AddLast(newRecord);
		}
		public void addlistOfServiceTire(Record newRecord) {
			listOfServiceTire.AddLast(newRecord);
		}
		}
	}
}
