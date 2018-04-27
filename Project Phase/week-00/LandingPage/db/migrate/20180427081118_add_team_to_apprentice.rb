class AddTeamToApprentice < ActiveRecord::Migration[5.2]
  def change
    add_reference :apprentices, :team, foreign_key: true
  end
end
