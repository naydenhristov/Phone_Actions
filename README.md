# Phone_Actions
Practice Strings Arrays and Methods 

Description:
You will be given an array of phone numbers (strings) and an array of names (strings). After which, you will be given strings on new lines, until you receive the command “done”. 

A number corresponds to a name when it’s located on the same position as its corresponding name in both arrays.

Implement a phone with this functionality:
- call {number/name} -> print “calling {name/number}...”
- If the sum of the digits (ignore other characters) of the number is odd, print “no answer”.
- If the sum of the digits (ignore other characters) of the number is even, print “call ended. duration: {duration}”. The duration is calculated from the sum of the digits in the format “mm:ss”

- message {number/name} -> print “sending sms to {name/number}...”
- if the difference of the digits (ignore other characters) of the number is odd, print “busy”
- if the difference of the digits (ignore other characters) of the number is even, print “meet me there”

Constraints:
- The numbers will contain the digits 0-9 and might contain the plus sign "+". They will always be valid and in this format.
- The numbers and names will be unique – there will be no cases of repeated numbers or repeated names.
- The names and numbers will always be separated by exactly one whitespace.

Examples:

Input:
(602)207-2544 +918671613200 1-661-335-8202
John Prakash Felix
call Prakash
call John
call Felix
done


Output:
calling +918671613200
call ended. duration: 00:44
calling (602)207-2544
call ended. duration: 00:32
calling 1-661-335-8202
no answer
---------------------------------

Input:
0882983983 0822223321 0898128398 0878223211
Vasil Hristo Georgi Luben
message Vasil
message 0878223211
message Hristo
done

Output:
sending sms to 0882983983...
meet me there
sending sms to Luben
meet me there
sending sms to 0822223321...
busy
---------------------------------

Input:
0888888888 0888123456 +359886001122
Nikolai Ivan Maria
call 0888888888
call Ivan
message Maria
done

Output:
calling Nikolai...
call ended. duration: 01:12
calling 0888123456...
no answer
sending sms to +359886001122...
busy
