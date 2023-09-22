# Project_Case_One
 
Coupon Code generator creates 8 digit codes using given char set e.g "ACDEFGHKLMNPRTXYZ234579".

Code is seperated into the two sections. First section is randomized part, and the other section is checksum part for checking validity.

Creating Code steps:
    -> Select random 5 chars from given list
    -> Sum theirs ASCII values
    -> Represent this sum as the original checksum
    -> Find the char correspondings of the original checksum digits using checkSumDict
    -> Add these correspondings to the randomized part as encrypted checksum


App Usage:

    Creating Code:
        -> Run the app
        -> Select 1
        -> Enter the num of coupon code count you need
        -> Codes are generated
    
    Validating Code:
        -> Run the app
        -> Select 2
        -> Enter the code