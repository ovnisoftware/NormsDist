NormsDist
=========

C# Implementation of the Excel NormsDist function

NormsDist is a statistical function in Excel.  It's useful for calculating the area under a a curve and for calculating
probabilities.  For example, if you want to calculate the probability of something occuring between +1 and +3
standard deviations, just run this function:

```
//Probability of being below 3 standard deviations is 99.86%
//minus the probability of being above 1 standard deviation
//is 84.13%, so you get .1573 or 15.73% as the answer.
double answer = NormsDist.N(3) - NormsDist.N(1);
```

I found the code here:

http://www.wilmott.com/messageview.cfm?catid=8&threadid=78622

but couldn't find it on Github so I figured I would post it.  Thanks to the Wilmott members.
