public class Program{

    public string Prefix(string strs){
        // strs = ["reflower","flow","flight"]
        var prefix = "";

        if(strs.Length == 1){
            prefix = strs[0];
            return prefix;
        }

        var shortestWordLength = 0;

        for(var i = 0; i < strs.Length; i++){

            if(shortestWordLength == 0){
                shortestWordLength = strs[i].Length;

            } else if(shortestWordLength > strs[i].Length){
                shortestWordLength = strs[i].Length;
            }
        }

        var matchingLetter = true;

        for(var letterCounter = 0; letterCounter < shortestWordLength; letterCounter++){
            for(var i = 1; i < strs.Length; i++){
                if(matchingLetter == true){
                    // i = 1
                    // ["reflower","flow","flight"]
                    var word = strs[i]; // "flow"
                    var previousWord = strs[i-1]; // "reflower"

                    if(word == "" || previousWord == ""){
                        prefix = "";
                        return prefix;
                    }

                    var wl  = word[letterCounter]; // "f"
                    var pwl = previousWord[letterCounter]; // "r"

                    if(wl == pwl){
                        matchingLetter = true;
                        if(i == strs.Length - 1){
                            prefix += wl;
                        }

                    } else{
                        matchingLetter = false;
                    }
                }
            }
        }

        return prefix;
    }


}
