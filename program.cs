public class Program{

    public int StrStr(string haystack, string needle) {
        var n = needle.Length - 1;
        var potentialStart = -1;
        var needlePointer = 1;

        if(haystack.Length < needle.Length){
            return potentialStart;
        }

        for(var i = 0; i < haystack.Length; i++){
            if(potentialStart == -1){
                if(haystack[i] == needle[0]){
                    if(i + n < haystack.Length && haystack[i + n] == needle[n]){
                        potentialStart = i;
                    }
                }
            } else{
                if(n == 0){
                    return potentialStart;

                } else{
                    if(haystack[i] == needle[needlePointer]){
                        if(needlePointer < n){
                            needlePointer++;
                        } else{
                            return potentialStart;
                        }
                    } else{
                        i = potentialStart;
                        potentialStart = -1;
                        needlePointer = 1;
                    }
                }
            }
        }

        return potentialStart;
    }
}
