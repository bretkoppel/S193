//
//  PlayingCard.m
//  Matchismo
//
//  Created by Bret Koppel on 8/21/14.
//  Copyright (c) 2014 Bret Koppel. All rights reserved.
//

#import "PlayingCard.h"

@implementation PlayingCard

// if you override BOTH getter and setter, must
// synthesize yourself.
@synthesize suit = _suit;

- (void)setSuit:(NSString *)suit{
    if ([[PlayingCard validSuits] containsObject:suit])
        _suit = suit;
}

- (NSString *)suit {
    return _suit ? _suit : @"?";
}

- (void)setRank:(NSUInteger)rank {
    if (rank <= [PlayingCard maxRank])
        _rank = rank;
}

- (NSString *)contents{
    NSArray *rankStrings = [PlayingCard rankStrings];
    return [rankStrings[self.rank] stringByAppendingString:self.suit];
}

+ (NSArray *)rankStrings {
    return @[@"?",@"A",@"2",@"3", @"4", @"5", @"6", @"7", @"8", @"9", @"10", @"J", @"Q", @"K"];
}

+ (NSArray *)validSuits {
    return @[@"♣︎",@"♦︎",@"♥︎",@"♠︎"];
}

+ (NSUInteger)maxRank {
    return [[self rankStrings] count] -1;
}

@end
