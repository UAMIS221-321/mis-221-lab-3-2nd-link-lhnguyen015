

static string GetEnjoymentLevel(){
	System.Console.WriteLine("What enjoyment level do you want?");
	return Console.ReadLine();
}

static string GetStadiumRecommendation(string enjoymentLevel){
	if(enjoymentLevel == "Boring"){
		return "Neyland Stadium";
	}
	if(enjoymentLevel == "Average") {
		return "Jordan-Hare Stadium";
	}
	if(enjoymentLevel == "Fun"){
		return "Tiger Stadium";
	}
	if(enjoymentLevel == "Epic"){
		return "Saban Field at Bryant-Denny Stadium";
	}
	else {
		return "Invalid Answer!";
	}
}

static string GetGameRecommendation(string stadium){
	if(stadium == "Neyland Stadium"){
		return "Tennessee vs Kent State";
	}
	if(stadium == "Jordan-Hare Stadium") {
		return "Auburn vs Kentucky";
	}
	if(stadium == "Tiger Stadium"){
		return "LSU vs Alabama";
	}
	if(stadium == "Saban Field at Bryant-Denny Stadium"){
		return "Alabama vs Auburn";
	}
	else {
		return "Invalid Answer!";
	}
}

static void DisplayStadiumDetails(string stadium, string game){
	System.Console.WriteLine("Best stadium: " + stadium);
System.Console.WriteLine("Best game: " + game);
}




string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);
DisplayStadiumDetails(stadium, game);










