namespace ApiRequestExample.Models
{
    /*
     * This is an example of the JSON response we will get from the animal facts API
     * 
     * https://alexwohlbruck.github.io/cat-facts/docs/endpoints/facts.html
     * 
     * NOTE: the API will respond with an array of objects, so in our service we will expect a
     * collection of AnimalFactResponse objects. This class represents one object in the array
     * from this JSON sample
     * 
     * [
	 * 	  {  
	 * 	  	  "_id": "591f9894d369931519ce358f",
	 * 	  	  "__v": 0,
	 * 	  	  "text": "A female cat will be pregnant for approximately 9 weeks - between 62 and 65 days from conception to delivery.",
	 * 	  	  "updatedAt": "2018-01-04T01:10:54.673Z",
	 * 	  	  "deleted": false,
	 * 	  	  "source": "api",
	 * 	  	  "sentCount": 5
	 * 	  },
	 * 	  {  
	 * 	  	  "_id": "591f9854c5cbe314f7a7ad34",
	 * 	  	  "__v": 0,
	 * 	  	  "text": "It has been scientifically proven that stroking a cat can lower one's blood pressure.",
	 * 	  	  "updatedAt": "2018-01-04T01:10:54.673Z",
	 * 	  	  "deleted": false,
	 * 	  	  "source": "api",
	 * 	  	  "sentCount": 3
	 * 	  }  
	 * ]
     * 
     */


    public class AnimalFact
    {
		public string? _id { get; set; }
		public int __v { get; set; }
		public string? text { get; set; }
		public DateTime updatedAt { get; set; }
		public bool deleted { get; set; }
		public string? source { get; set; }
		public int sentCount { get; set; }
    }
}
