//
//  Card.m
//  Matchismo
//
//  Created by Bret Koppel on 8/21/14.
//  Copyright (c) 2014 Bret Koppel. All rights reserved.
//

#import "Card.h"

@implementation Card

- (int)match:(NSArray *)otherCards{
    int score = 0;
    for (Card *card in otherCards){
        if ([card.contents isEqualToString:self.contents])
            score = 1;
    }
    
    return score;
}
@end
