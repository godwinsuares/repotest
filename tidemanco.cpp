#include <stdio.h>
#include <stdbool.h>

#define MAX_CANDIDATES 10
#define MAX_VOTERS 50

int preferences[MAX_VOTERS][MAX_CANDIDATES];
int locked[MAX_CANDIDATES][MAX_CANDIDATES];
int candidate_count;
int voter_count;

bool vote(int rank, char name[20], int ranks[]);
void record_preferences(int ranks[]);
void add_pairs(void);
void sort_pairs(void);
void lock_pairs(void);
void print_winner(void);

int main(int argc, char *argv[])
{
    // Check for invalid usage
    if (argc < 2)
    {
        printf("Usage: tideman [candidate ...]\n");
        return 1;
    }
    // Populate array of candidates
    candidate_count = argc - 1;
    if (candidate_count > MAX_CANDIDATES)
    {
        printf("Maximum number of candidates is %i\n", MAX_CANDIDATES);
        return 2;
    }
    for (int i = 0; i < candidate_count; i++)
    {
        printf("Candidate %i: %s\n", i + 1, argv[i + 1]);
    }
    voter_count = get_int("Number of voters: ");
    if (voter_count > MAX_VOTERS)
    {
        printf("Maximum number of voters is %i\n", MAX_VOTERS);
        return 3;
    }
    // Query for votes
    for (int i = 0; i < voter_count; i++)
    {
        // ranks[i] is voter i's ith preference
        int ranks[candidate_count];
        // Query for each rank
        for (int j = 0; j < candidate_count; j++)
        {
            char name[20];
            printf("Rank %i: ", j + 1);
            scanf("%s", name);
            if (!vote(j, name, ranks))
            {
                printf("Invalid vote.\n");
                return 4;
            }
        }
        record_preferences(ranks);
        printf("\n");
    }
    add_pairs();
    sort_pairs();
    lock_pairs();
    print_winner();
    return 0;
}

// Update ranks given a new vote
bool vote(int rank, char name[20], int ranks[])
{
    // TODO
    for (int i = 0; i < candidate_count; i++)
    {
        if (strcmp(name, argv[i + 1]) == 0)
        {
            ranks[rank] = i;
            return true;
        }
    }
    return false;
}

// Update preferences given one voter's ranks
void record_preferences(int ranks[])
{
    // TODO
    for (int i = 0; i < candidate_count - 1; i++)
    {
        preferences[ranks[i]][ranks[i + 1]]++;
    }
    return;
}

// Record pairs of candidates where one is preferred over the other
void add_pairs(void)
{
    // TODO
    int pair_count = 0;
    for (int i = 0; i < candidate_count; i++)
    {
        for (int j = 1; j < candidate_count; j++)
        {
            if (preferences[i][j] > preferences[j][i])
            {
                pair_count++;
                locked[i][j] = true;
            }
            else if (preferences[i][j] < preferences[j][i])
            {
                pair_count++;
                locked[j][i] = true;
            }
        }
    }
    return;
}

// Sort pairs in decreasing order by strength of victory
void sort_pairs(void)
{
    // TODO
    int temp[2];
    for (int i = 0; i < candidate_count; i++)
    {
        for (int j = 1; j < candidate_count; j++)
        {
            if (preferences[i][j] > preferences[j][i])
            {
                temp[0] = preferences[i][j];
                temp[1] = preferences[j][i];
                preferences[i][j] = temp[1];
                preferences[j][i] = temp[0];
            }
        }
    }
    return;
}
