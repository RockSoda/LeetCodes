class Solution(object):
    
    def longestCommonPrefix(self, strs):
        minLen = len(min(strs, key = len))
        
        output = ""
        
        for i in range(minLen):
            chr = ''
            for str in strs:
                if chr == '':
                    chr = str[i]
                curr = str[i]
                
                if curr != chr:
                    return output
            output += chr
        
        return output
                