class Team < ApplicationRecord
	extend Dragonfly::Model
	dragonfly_accessor :image
	has_many :apprentices
end
